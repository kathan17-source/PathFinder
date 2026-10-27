"""Inventory numbered problem entries in the ASPX source; does not fetch linked content."""
from __future__ import annotations

import json
import re
from collections import Counter
from html.parser import HTMLParser
from pathlib import Path
from urllib.parse import urlparse

ROOT = Path(__file__).resolve().parents[1]


class CatalogParser(HTMLParser):
    def __init__(self):
        super().__init__()
        self.section = ""
        self.current = None
        self.heading = False
        self.heading_text = ""
        self.entries = []

    def handle_starttag(self, tag, attrs):
        attributes = dict(attrs)
        if tag == "h3":
            self.heading = True
            self.heading_text = ""
        if tag == "a" and "button1" in attributes.get("class", "").split():
            self.current = {"section": self.section, "attributes": attributes, "label": ""}

    def handle_data(self, data):
        if self.heading:
            self.heading_text += data
        if self.current is not None:
            self.current["label"] += data

    def handle_endtag(self, tag):
        if tag == "h3":
            self.heading = False
            self.section = self.heading_text.strip()
        if tag == "a" and self.current is not None:
            self.entries.append(self.current)
            self.current = None


def audit():
    pages = []
    all_urls = []
    for path in sorted(ROOT.glob("[0-9][0-9]_*.aspx")):
        parser = CatalogParser()
        parser.feed(path.read_text(encoding="utf-8-sig"))
        counts = Counter()
        identities = set()
        placeholders = []
        for entry in parser.entries:
            label = entry["label"].strip()
            match = re.fullmatch(r"(\d+)\s*(?:[-–]\s*(\d+))?", label)
            if not match:
                raise ValueError(f"Unexpected numbered label: {path.name}: {label}")
            first = int(match[1])
            last = int(match[2] or match[1])
            assert first <= last
            keys = {(entry["section"], n) for n in range(first, last + 1)}
            assert not identities & keys, (path.name, label, "duplicate problem")
            identities |= keys
            attributes = entry["attributes"]
            url = attributes.get("href", "").strip()
            disabled = "buttonDisable" in attributes.get("class", "").split() or "disabled" in attributes
            if disabled:
                status = "disabled"
            elif urlparse(url).scheme in {"http", "https"} and urlparse(url).netloc:
                status = "external_link"
                all_urls.append(url)
            else:
                status = "unavailable_placeholder"
                placeholders.append({"section": entry["section"], "label": label, "href": url})
            counts["buttons"] += 1
            counts["problems"] += len(keys)
            counts[status + "_buttons"] += 1
            counts[status + "_problems"] += len(keys)
        pages.append({"page": path.name, **dict(counts), "placeholders": placeholders})
    total = Counter()
    for page in pages:
        total.update({k: v for k, v in page.items() if isinstance(v, int)})
    return {"method": "ASPX anchors with button1; inclusive numeric ranges; identities are page/section/problem number", "totals": dict(total), "unique_external_urls": len(set(all_urls)), "pages": pages, "external_availability": "Not established by source inventory; Google Drive permissions and solution correctness require separate verification"}


if __name__ == "__main__":
    print(json.dumps(audit(), indent=2))
