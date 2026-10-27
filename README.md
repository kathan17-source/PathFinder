# PathFinder — Physics Olympiad Problem & Solution Index

PathFinder is an ASP.NET Web Forms study companion for senior-secondary physics Olympiad preparation. Sixteen chapter pages organize numbered problem references from the Pathfinder physics material into multiple-choice, understanding and challenge sections, with links to externally hosted solution resources where configured. It is a browsable index, not a bundled textbook or a verified collection of complete worked solutions.

## What is actually available

The source contains **1,250 navigation buttons covering 1,293 numbered problem references**. Some buttons cover ranges of problems. The [reproducible catalog inventory](docs/CATALOG_INVENTORY.md) distinguishes buttons, problem numbers and external availability:

| Source category | Buttons | Numbered problem references |
|---|---:|---:|
| Configured external solution links | 1,029 | 1,070 |
| Disabled placeholders | 210 | 212 |
| Other unavailable placeholders | 11 | 11 |
| Total | 1,250 | 1,293 |

There are 1,029 unique Google Drive URLs. A configured link is **not a verified working solution**: access permissions, live availability, solution contents and correctness have not been established for the full collection. Ten unavailable placeholders have no `href`; one uses `href="#"`. No missing solution is invented or implied by these counts.

The chapters cover kinematics through modern physics. The repository includes the Web Forms application shell, shared navigation, styles and client libraries; questions and solution resources remain external. The home page still contains the standard ASP.NET starter content, so open a numbered chapter to inspect the physics catalog.

## Structure

```text
PathFinder/
├── 01_kinematics.aspx ... 16_ModernPhysics.aspx  # Numbered topic pages
├── App_Start/                                    # Routes and asset bundles
├── Content/                                      # Site and Bootstrap styles
├── Scripts/                                      # jQuery, Bootstrap, Modernizr, Web Forms scripts
├── Properties/                                   # Assembly metadata
├── Site.Master                                   # Shared desktop layout/navigation
├── Site.Mobile.Master                            # Mobile layout
├── ViewSwitcher.ascx                             # Desktop/mobile view switcher
├── Default.aspx                                  # Application landing page
├── PathFinder.csproj and PathFinder.sln          # Visual Studio project/solution
├── packages.config                               # NuGet dependency manifest
└── Web.config                                    # ASP.NET runtime configuration
```

Each `.aspx` page is accompanied by its C# code-behind (`.aspx.cs`) and generated control declaration (`.aspx.designer.cs`). The numbered filenames preserve the intended learning order and make individual topics easy to locate.

## Languages and tools

- C# and ASP.NET Web Forms
- HTML/ASPX markup and CSS
- JavaScript
- .NET Framework 4.7.2
- Visual Studio 2019 or later with the **ASP.NET and web development** workload
- NuGet package restore
- Bootstrap 5.2.3, jQuery 3.7.0, and Modernizr 2.8.3 (third-party client assets restored through NuGet and retained where referenced)
- Microsoft ASP.NET Web Forms, Friendly URLs, Web Optimization, and Microsoft Ajax support packages

## Requirements

This is a classic .NET Framework application. Building and running it requires Windows because ASP.NET Web Forms and the full .NET Framework are not supported by modern cross-platform `dotnet` alone.

Install:

1. Windows 10 or later.
2. Visual Studio 2019 or 2022.
3. The **ASP.NET and web development** workload.
4. The .NET Framework 4.7.2 targeting pack (select it in the Visual Studio Installer if it is not already present).

All project dependencies are declared in `packages.config`; no separate Node.js or Python installation is required.

## Installation

From a Developer Command Prompt for Visual Studio:

```bat
git clone https://github.com/kathan17-source/PathFinder.git
cd PathFinder
nuget restore PathFinder.sln
msbuild PathFinder.sln /p:Configuration=Debug
```

Alternatively, open `PathFinder.sln` in Visual Studio. Visual Studio normally restores the NuGet packages automatically; if it does not, right-click the solution and select **Restore NuGet Packages**.

## Running the application and opening chapters

In Visual Studio:

1. Open `PathFinder.sln`.
2. Set `PathFinder` as the startup project.
3. Press `F5` to run with debugging or `Ctrl+F5` to run without debugging.

To open a specific chapter, append its page name to the local URL shown by Visual Studio. For example:

```text
https://localhost:<port>/01_kinematics.aspx
https://localhost:<port>/05_Rotation.aspx
https://localhost:<port>/16_ModernPhysics.aspx
```

The remaining chapter URLs follow the same numbered filenames visible at the repository root. You can also navigate between chapters from the website menu.

## Testing

The repository does not contain an automated test project. Use the following checks on Windows:

```bat
nuget restore PathFinder.sln
msbuild PathFinder.sln /t:Rebuild /p:Configuration=Debug
```

After the build succeeds, launch the site and perform a smoke test:

1. Open the home page.
2. Open each numbered topic page from `01` through `16`.
3. Confirm the navigation, styles, solution links, disabled placeholders, and mobile view render correctly.
4. Confirm the browser console and server output show no errors.

[Windows CI](https://github.com/kathan17-source/PathFinder/actions/runs/40463577633) reproduced the inventory, restored NuGet packages and successfully rebuilt the application in Release configuration on Windows Server 2022 with Visual Studio 2022 MSBuild and .NET Framework 4.7.2. IIS Express/browser runtime and external solution availability remain unverified. To reproduce the catalog count with optional Python 3 tooling, run `python Scripts/audit_catalog.py`; Python is not required by the Web Forms application itself.

## Example usage

To review rotational mechanics, start the application and browse directly to:

```text
https://localhost:<port>/05_Rotation.aspx
```

## Author

Kathan Patel

## License

The original application code authored by Kathan Patel is licensed under the [MIT License](LICENSE). The license does not cover third-party libraries, externally linked resources, Pathfinder materials, course materials, questions, or solutions; those remain subject to their respective owners' rights and terms.
