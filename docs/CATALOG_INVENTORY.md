# Catalog inventory

This is a source audit of the sixteen numbered ASPX pages. It counts numbered anchors with class `button1`, expands inclusive ranges such as `24 - 25`, and identifies a problem reference by chapter, section and number. No duplicate reference was found within those identities. Counts describe indexed references, not independently inspected problem/solution contents.

Reproduce with optional Python 3 (no third-party packages):

```sh
python Scripts/audit_catalog.py
```

Compare the output with [catalog-inventory.json](catalog-inventory.json). The audit does not fetch, download or redistribute externally linked material.

| Chapter | Problem references | External link buttons | Disabled buttons | Other unavailable buttons |
|---|---:|---:|---:|---:|
| [01_kinematics.aspx](../01_kinematics.aspx) | 116 | 108 | 0 | 0 |
| [02_LawsOfMotion.aspx](../02_LawsOfMotion.aspx) | 144 | 134 | 6 | 0 |
| [03_WorkEnergyAndPower.aspx](../03_WorkEnergyAndPower.aspx) | 73 | 63 | 8 | 0 |
| [04_CentreOfMass.aspx](../04_CentreOfMass.aspx) | 100 | 66 | 29 | 0 |
| [05_Rotation.aspx](../05_Rotation.aspx) | 113 | 84 | 26 | 0 |
| [06_Gravitation.aspx](../06_Gravitation.aspx) | 26 | 26 | 0 | 0 |
| [07_Fluids.aspx](../07_Fluids.aspx) | 68 | 50 | 17 | 0 |
| [08_ThermalPhysics.aspx](../08_ThermalPhysics.aspx) | 109 | 57 | 49 | 0 |
| [09_PropertiesOfMatter.aspx](../09_PropertiesOfMatter.aspx) | 33 | 23 | 0 | 10 |
| [10_WavesAndOscillations.aspx](../10_WavesAndOscillations.aspx) | 57 | 48 | 9 | 0 |
| [11_Optics.aspx](../11_Optics.aspx) | 71 | 52 | 15 | 0 |
| [12_Electrostatics.aspx](../12_Electrostatics.aspx) | 117 | 103 | 12 | 0 |
| [13_ElectricCurrent.aspx](../13_ElectricCurrent.aspx) | 100 | 90 | 7 | 0 |
| [14_MagneticEffectsOfCurrent.aspx](../14_MagneticEffectsOfCurrent.aspx) | 55 | 38 | 13 | 0 |
| [15_ElectromagneticInduction.aspx](../15_ElectromagneticInduction.aspx) | 77 | 57 | 19 | 1 |
| [16_ModernPhysics.aspx](../16_ModernPhysics.aspx) | 34 | 30 | 0 | 0 |

**Totals:** 1,250 buttons represent 1,293 problem references. There are 1,029 configured external buttons/unique Google Drive URLs covering 1,070 references; 210 disabled buttons covering 212 references; and 11 other unavailable buttons covering 11 references. Thus 223 numbered references have no usable configured link in the source, before considering any inaccessible external resources.

The ten empty-link entries are in Properties of Matter: MCQ 03; Build Your Understanding 10; Check Your Understanding 01, 02, 04, 06 and 07; Challenge Your Understanding 01, 02 and 03. Electromagnetic Induction / Challenge Your Understanding 01 points to `#`. These are separate from the 210 `buttonDisable` entries.

## What is not verified

The inventory establishes configured destinations, not 1,029 accessible/correct solutions. Google Drive permissions, deleted files, login requirements, document identity and correctness require a separate authorized content review. Even a successful HTTP status or Drive viewer response would not prove those properties. No restricted files were acquired to fill gaps. Disabled placeholders and all application links remain unchanged.

The project targets .NET Framework 4.7.2 and ASP.NET Web Forms. [Windows CI](https://github.com/kathan17-source/PathFinder/actions/runs/40463577633) successfully restored packages and rebuilt Release with Visual Studio 2022 MSBuild on Windows Server 2022. IIS Express/browser smoke testing remains unverified; modern cross-platform dotnet alone is insufficient. The landing page is still the ASP.NET starter template. [README](../README.md) contains Windows prerequisites and build/run instructions. [LICENSE](../LICENSE) is unchanged and does not cover externally linked resources.
