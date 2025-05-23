# Scarecrow.WebApi

[![NuGet Version](https://img.shields.io/nuget/v/Scarecrow.WebApi.Template.svg?style=flat-square)](https://www.nuget.org/packages/Scarecrow.WebApi.Template/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Scarecrow.WebApi.Template.svg?style=flat-square)](https://www.nuget.org/packages/Scarecrow.WebApi.Template/)
[![License](https://img.shields.io/github/license/muhirwanto-dev/scarecrow?style=flat-square)](LICENSE)
[![GitHub Issues](https://img.shields.io/github/issues/muhirwanto-dev/scarecrow?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/issues)
[![GitHub Stars](https://img.shields.io/github/stars/muhirwanto-dev/scarecrow?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/stargazers)
[![GitHub Forks](https://img.shields.io/github/forks/muhirwanto-dev/scarecrow?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/network/members)
[![Contributions Welcome](https://img.shields.io/badge/Contributions-Welcome-brightgreen.svg?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/pulls)

## Overview

This .NET Web API template implements Clean Architecture principles (inspired by [`amantiband/clean-architecture`](https://github.com/amantinband/clean-architecture)). It comes pre-configured with `Routing Convention`, `Logging` with `Serilog`, middleware integration for exception & logging handler, object mapping with `Mapperly`, and API versioning.

## Key Features

* **Routing Convention**: Use *kebab-case* routing convention.
* **Robust Logging**: Powered by [`Serilog`](https://github.com/serilog/serilog).
* **Integrated Middleware**: Streamlined for handling exceptions and logging.
* **Object Mapping**: Efficiently managed with [`Mapperly`](https://github.com/riok/mapperly).
* **API Versioning**: Enabling smooth API evolution.

## Installation

Install the template from Package Manager console:

**Package Manager Console:**

```powershell
dotnet new install Scarecrow.WebApi.Template
```

**.NET CLI**
```bash
dotnet new install Scarecrow.WebApi.Template
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

1.  Check the [GitHub Issues](https://github.com/muhirwanto-dev/scarecrow/issues) to see if your issue or idea has already been reported.
2.  If not, open a new issue to describe the bug or feature request.
3.  **For code contributions:**
    * Fork the Project repository.
    * Create your Feature Branch (`git checkout -b feature/YourAmazingFeature`).
    * Commit your Changes (`git commit -m 'Add YourAmazingFeature'`). Adhere to conventional commit messages if possible.
    * Push to the Branch (`git push origin feature/YourAmazingFeature`).
    * Open a Pull Request against the `main` branch of the original repository.
4.  Please try to follow the existing coding style and include unit tests for new or modified functionality.

## License

Distributed under the [MIT License](https://github.com/muhirwanto-dev/scarecrow/tree/main?tab=MIT-1-ov-file#readme). See the `LICENSE` file in the repository for more information.

## Contact

[@muhirwanto-dev](https://github.com/muhirwanto-dev)

Project link: [https://github.com/muhirwanto-dev/scarecrow/tree/main/src/Scarecrow.WebApi](https://github.com/muhirwanto-dev/scarecrow/tree/main/src/Scarecrow.WebApi)
