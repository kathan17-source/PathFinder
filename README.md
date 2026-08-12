# PathFinder Solutions

PathFinder Solutions is an ASP.NET Web Forms website containing concise, chapter-by-chapter physics notes and worked formula references for senior-secondary students.

## What Pathfinder is

Pathfinder is a study companion for navigating core physics topics. It presents definitions, equations, principles, and examples in a browsable web application rather than as isolated documents.

## Repository contents

The repository contains 16 numbered physics solution pages covering kinematics through modern physics, plus the shared Web Forms application shell, styling, client-side libraries, and project configuration.

## Structure

```text
PathFinder/
├── 01_kinematics.aspx ... 16_ModernPhysics.aspx  # Numbered topic pages
├── App_Start/                                    # Routes and asset bundles
├── Content/                                      # Site and Bootstrap styles
├── Scripts/                                      # jQuery, Bootstrap, Modernizr, Web Forms scripts
├── Properties/                                   # Assembly metadata
├── Image/                                        # Site image assets
├── Site.Master                                   # Shared desktop layout/navigation
├── Site.Mobile.Master                            # Mobile layout
├── Default.aspx                                  # Application landing page
├── About.aspx and Contact.aspx                   # Supporting pages
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
- Bootstrap 5.2.3, jQuery 3.7.0, and Modernizr 2.8.3

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

## Running the application and individual solutions

In Visual Studio:

1. Open `PathFinder.sln`.
2. Set `PathFinder` as the startup project.
3. Press `F5` to run with debugging or `Ctrl+F5` to run without debugging.

To open a specific solution, append its page name to the local URL shown by Visual Studio. For example:

```text
https://localhost:<port>/01_kinematics.aspx
https://localhost:<port>/05_Rotation.aspx
https://localhost:<port>/16_ModernPhysics.aspx
```

The remaining solution URLs follow the same numbered filenames visible at the repository root. You can also navigate between chapters from the website menu.

## Testing

The archive does not contain an automated test project. Use the following checks on Windows:

```bat
nuget restore PathFinder.sln
msbuild PathFinder.sln /t:Rebuild /p:Configuration=Debug
```

After the build succeeds, launch the site and perform a smoke test:

1. Open the home, About, and Contact pages.
2. Open each numbered topic page from `01` through `16`.
3. Confirm the navigation, styles, equations, and mobile view render correctly.
4. Confirm the browser console and server output show no errors.

## Example usage

To review rotational mechanics, start the application and browse directly to:

```text
https://localhost:<port>/05_Rotation.aspx
```

## Author

Kathan Patel

## License

Licensed under the [MIT License](LICENSE).
