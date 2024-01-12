# LethalCompanyTemplate

# Setup

## Configuring the project

In the [csproj](LethalCompanyTemplate/LethalCompanyTemplate.csproj) file,
in the `PropertyGroup` section, there are some properties that you can change to help you configure the project.

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
