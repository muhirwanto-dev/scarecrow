# Templator

[![NuGet Version](https://img.shields.io/nuget/v/Templator.CoreWebApi.svg?style=flat-square)](https://www.nuget.org/packages/Templator.CoreWebApi/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Templator.CoreWebApi.svg?style=flat-square)](https://www.nuget.org/packages/Templator.CoreWebApi/)
[![License](https://img.shields.io/github/license/muhirwanto-dev/templator?style=flat-square)](LICENSE)
[![GitHub Issues](https://img.shields.io/github/issues/muhirwanto-dev/templator?style=flat-square)](https://github.com/muhirwanto-dev/templator/issues)
[![GitHub Stars](https://img.shields.io/github/stars/muhirwanto-dev/templator?style=flat-square)](https://github.com/muhirwanto-dev/templator/stargazers)
[![GitHub Forks](https://img.shields.io/github/forks/muhirwanto-dev/templator?style=flat-square)](https://github.com/muhirwanto-dev/templator/network/members)
[![Contributions Welcome](https://img.shields.io/badge/Contributions-Welcome-brightgreen.svg?style=flat-square)](https://github.com/muhirwanto-dev/templator/pulls)

## Overview

This .NET Web API template implements Clean Architecture principles (inspired by [`amantiband/clean-architecture`](https://github.com/amantinband/clean-architecture)). It comes pre-configured with `Routing Convention`, `Logging` with `Serilog`, middleware integration for exception & logging handler, object mapping with `Mapperly`, and API versioning.

## Key Features

* **Routing Convention**: Use *kebab-case* routing convention.
* **Robust Logging**: Powered by [`Serilog`](https://github.com/serilog/serilog).
* **Integrated Middleware**: Streamlined for handling exceptions and logging.
* **Object Mapping**: Efficiently managed with [`Mapperly`](https://github.com/riok/mapperly).
* **API Versioning**: Enabling smooth API evolution.

## Installation

Install the abstractions package via NuGet:

**Package Manager Console:**

```powershell
Install-Package Templator.CoreWebApi
```

**.NET CLI**
```bash
dotnet add package Templator.CoreWebApi
```

## Usage

**Install Template**

Go to `<root>\src\CoreWebApi\src`.
```bash
dotnet new install ./
```

**Uninstall Template**

Go to `<root>\src\CoreWebApi\src`.
```bash
dotnet new uninstall ./
```

## Library Used In This Template
This template leverages a set of robust libraries and frameworks to implement Clean Architecture and other best practices.

|Package|Version|License|
|-------------|-------------|-------------|
|[SingleScope.Persistence](https://github.com/muhirwanto-dev/singlescope-plugins)|3.2.0|[MIT](https://github.com/muhirwanto-dev/singlescope-plugins?tab=MIT-1-ov-file#readme)|
|[MediatR](https://github.com/jbogard/MediatR)|12.5.0|[Apache-2.0](https://github.com/jbogard/MediatR?tab=Apache-2.0-1-ov-file#readme)|
|[ErrorOr](https://github.com/amantinband/error-or)|2.0.1|[MIT](https://github.com/amantinband/error-or?tab=MIT-1-ov-file#readme)|
|[SmartEnum](https://github.com/ardalis/SmartEnum)|8.2.0|[MIT](https://github.com/ardalis/SmartEnum?tab=MIT-1-ov-file#readme)|
|[Serilog](https://github.com/serilog/serilog)|4.2.0|[Apache-2.0](https://github.com/serilog/serilog?tab=Apache-2.0-1-ov-file#readme)|
|[FluentValidation](https://github.com/FluentValidation/FluentValidation)|12.0.0|[Apache-2.0](https://github.com/FluentValidation/FluentValidation?tab=Apache-2.0-1-ov-file#readme)|
|[Mapperly](https://github.com/riok/mapperly)|4.2.1|[Apache-2.0](https://github.com/riok/mapperly?tab=Apache-2.0-1-ov-file#readme)|
|[ApiExplorer](https://github.com/dotnet/aspnet-api-versioning)|8.1.0|[MIT](https://github.com/dotnet/aspnet-api-versioning?tab=MIT-1-ov-file#readme)|

## Contributions

Contributions are welcome! If you encounter a bug, have a suggestion, or want to contribute code, please follow these steps:

1.  Check the [GitHub Issues](https://github.com/muhirwanto-dev/templator/issues) to see if your issue or idea has already been reported.
2.  If not, open a new issue to describe the bug or feature request.
3.  **For code contributions:**
    * Fork the Project repository.
    * Create your Feature Branch (`git checkout -b feature/YourAmazingFeature`).
    * Commit your Changes (`git commit -m 'Add YourAmazingFeature'`). Adhere to conventional commit messages if possible.
    * Push to the Branch (`git push origin feature/YourAmazingFeature`).
    * Open a Pull Request against the `main` branch of the original repository.
4.  Please try to follow the existing coding style and include unit tests for new or modified functionality.

## License

Distributed under the [MIT License](https://github.com/muhirwanto-dev/templator/tree/main?tab=MIT-1-ov-file#readme). See the `LICENSE` file in the repository for more information.

## Contact

[@muhirwanto-dev](https://github.com/muhirwanto-dev)

Project link: [https://github.com/muhirwanto-dev/templator/tree/main/src/CoreWebApi](https://github.com/muhirwanto-dev/templator/tree/main/src/CoreWebApi)