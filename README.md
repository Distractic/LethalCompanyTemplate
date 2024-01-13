# LethalCompanyTemplate

# Setup

## Wiki

First of all, follow the [wiki](https://lethal.wiki/dev/initial-setup) to have a working development environment.

## Dotnet version

If you need to set the dotnet version, you can use the following command:

- Check the SDKs installed
```bash
dotnet --list-sdks
```

- Set the SDK version
```bash
dotnet new globaljson --sdk-version <version>

# Example
dotnet new globaljson --sdk-version 7.0.405
```

A new [global.json](https://learn.microsoft.com/en-us/dotnet/core/tools/global-json) file is created to set the SDK version to use.

## Configuring the project

In the [csproj](LethalCompanyTemplate/LethalCompanyTemplate.csproj) file,
the `PropertyGroup` section, there are some properties that you can change to help you to configure the project.

| Property                     | Description                                                                                                                                                             |
|------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| GameDir                      | The directory where the game is installed.                                                                                                                              |
| PluginGameDir                | The directory where the plugins are installed.                                                                                                                          |
| AssemblyGameDir              | The directory where the assemblies are installed.                                                                                                                       |
| GameExe                      | The name of the game executable.                                                                                                                                        |
| NumberOfClients              | The number of clients to launch when the project is built. This is recommended to be between 5 and 10 seconds to avoid problem with debug terminal and auto-start mods. |
| DelayBetweenClientsInSeconds | The delay between the launch of each client.                                                                                                                            |
| StartWhenBuilt               | If true, the clients will be launched when the project is built.                                                                                                        |

## Simplify test

To start the game automatically when a client is launched, you can install an auto-start mod
like [AutoStart](https://thunderstore.io/c/lethal-company/p/qwbarch/AutoStart/).

# Build

When you build the project, the following steps are executed:
- The built plugin is copied to the game plugin directory.
- The opened clients are closed.
- The game is launched.

The steps are defined in [csproj](LethalCompanyTemplate/LethalCompanyTemplate.csproj) file.

```bash
dotnet build
```

