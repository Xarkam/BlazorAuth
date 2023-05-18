# Blazor Auth [<img src="./Images/logo-blazor.png" align="center" width="48">](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET C#](https://img.shields.io/badge/.NET-C%23-blue)](https://docs.microsoft.com/en-us/dotnet/csharp/)


## Introduction
Simply a webassembly blazor app with auth mechanism.

## Dependencies
[Blazored LocalStorage](https://github.com/Blazored/LocalStorage) & 
[Blazored SessionStorage](https://github.com/Blazored/SessionStorage)

## Getting started

### Server project
Look into Server project for `appsettings.json` and adapt SQL connection string.

Don't forget to modify connection string into `program.cs`

Secret key for password encryption is in `appsettings.json`

```json
"AppSettings" : {
    "Token": "my top secret key"
  },
```
Juste replace `my top secret key` with your secret key.
