# LethalCompanyTemplate

Template to create Lethal Company plugins.

## Setup

### Wiki

First of all, follow the [wiki](https://lethal.wiki/dev/initial-setup) to have a working development environment.

### Dotnet version

> [!Note]
> [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) is recommended to build the project.

If you need to set the dotnet version, you can use the following command:

- Command to list the installed SDKs:

```bash
dotnet --list-sdks
```

- Command to set the dotnet version:

```bash
dotnet new globaljson --sdk-version <version>

# Example
dotnet new globaljson --sdk-version 7.0.405
```

A new [global.json](https://learn.microsoft.com/en-us/dotnet/core/tools/global-json) file is created to set the SDK
version to use.

### Configuration

The build configuration properties are findable in the `PropertyGroup` section of the files.

#### Common

The common build configuration is defined in the [Common.props](Common.props) file.
It's applied to [Template](Template) and [Test](Test) projects.

| Property        | Description                                       |
|-----------------|---------------------------------------------------|
| GameDir         | The directory where the game is installed.        |
| PluginGameDir   | The directory where the plugins are installed.    |
| AssemblyGameDir | The directory where the assemblies are installed. |
| GameExe         | The name of the game executable.                  |

#### Plugin

> [!Note]
> The configuration inherits from the [common configuration](#common).

The plugin build configuration is defined in the [Template.csproj](Template/Template.csproj) file.
It's applied only to [Template](Template) projects.

| Property                     | Description                                                                                                                                                             |
|------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| NumberOfClients              | The number of clients to launch when the project is built. This is recommended to be between 5 and 10 seconds to avoid problem with debug terminal and auto-start mods. |
| DelayBetweenClientsInSeconds | The delay between the start of each client.                                                                                                                             |
| StartGame                    | If true, the clients will be started when the project is built.                                                                                                         |

### Simplify test

To start the game automatically when a client is launched, you can install an auto-start mod
like [AutoStart](https://thunderstore.io/c/lethal-company/p/qwbarch/AutoStart/).

## Build

When you build the project, the following steps are executed:

- The built plugin is copied to the game plugin directory.
- The opened clients are closed.
- The game is launched.

The steps are defined in [Template.csproj](Template/Template.csproj) file.

Command to build the project:

```bash
dotnet build
```

## Test

> [!IMPORTANT]
> To run the tests, you need to have the environment installed and configured, because the project is built before the
> tests are executed.

Command to run the tests:

```bash
dotnet test -p:StartGame=false
```

