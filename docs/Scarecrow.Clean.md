# Scarecrow.Clean

[![NuGet Version](https://img.shields.io/nuget/v/Scarecrow.Clean.svg?style=flat-square)](https://www.nuget.org/packages/Scarecrow.Clean/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Scarecrow.Clean.svg?style=flat-square)](https://www.nuget.org/packages/Scarecrow.Clean/)
[![License](https://img.shields.io/github/license/muhirwanto-dev/scarecrow?style=flat-square)](LICENSE)
[![GitHub Issues](https://img.shields.io/github/issues/muhirwanto-dev/scarecrow?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/issues)
[![GitHub Stars](https://img.shields.io/github/stars/muhirwanto-dev/scarecrow?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/stargazers)
[![GitHub Forks](https://img.shields.io/github/forks/muhirwanto-dev/scarecrow?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/network/members)
[![Contributions Welcome](https://img.shields.io/badge/Contributions-Welcome-brightgreen.svg?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/pulls)

## Overview

A **Clean Architecture project template** for .NET 9 & .NET 10 inspired by [`amantiband/clean-architecture`](https://github.com/amantinband/clean-architecture). This template provides a **pure architectural foundation** without any delivery mechanism (API, UI, etc.).

## Architecture

The architecture was following [this](https://muhirwanto.notion.site/Well-Organized-Project-Hierarchy-29b333c30b3180198630f6b4f4596dc8).

```
src/
├─ Domain/
│ ├─ Catalogs/
│ │ ├─ Entities/
│ │ ├─ Events/
│ │ ├─ ValueObjects/
│ ├─ Common/
│ │ ├─ Entities/
│ │ │ ├─ AuditableEntity.cs
│ │ │ ├─ DomainEntity.cs
│ │ │ ├─ Entity.cs
│ │ │ ├─ NoKeyEntity.cs
│ │ │ ├─ RecoverableEntity.cs
│ └─ IDomainEvent.cs
│
├─ Application/
│ ├─ Catalogs/
│ │ ├─ Commands/
│ │ │ ├─ AddProduct/
│ │ │ │ ├─ AddProductCommand.cs
│ │ │ │ ├─ AddProductCommandHandler.cs
│ │ │ │ ├─ AddProductCommandValidator.cs
│ │ ├─ EventHandlers/
│ │ ├─ Queries/
│ ├─ Common/
│ │ ├─ Mapping/
│
├─ Infrastructure/
│ ├─ Persistence/
│ │ ├─ Contexts/
│ │ ├─ Repositories/
```

## Features

- Clean Architecture boundaries
- DDD-friendly domain model
- CQRS-ready structure
- Wolverine-ready messaging
- FluentValidation integration-ready
- Multi-targeting (.NET 9 & 10)

## Installation

Install the template from Package Manager console:

**Package Manager Console:**

```powershell
dotnet new install Scarecrow.Clean
```

**.NET CLI**
```bash
dotnet new install Scarecrow.Clean
```

## Library Used In This Template
This template leverages a set of robust libraries and frameworks to implement Clean Architecture and other best practices.

|Package|Version|License|
|-------------|-------------|-------------|
|[SingleScope.Persistence](https://github.com/muhirwanto-dev/singlescope-plugins)|5.1.0|[MIT](https://github.com/muhirwanto-dev/singlescope-plugins?tab=MIT-1-ov-file#readme)|
|[ErrorOr](https://github.com/amantinband/error-or)|2.0.1|[MIT](https://github.com/amantinband/error-or?tab=MIT-1-ov-file#readme)|
|[SmartEnum](https://github.com/ardalis/SmartEnum)|8.2.0|[MIT](https://github.com/ardalis/SmartEnum?tab=MIT-1-ov-file#readme)|
|[Serilog](https://github.com/serilog/serilog)|4.3.0|[Apache-2.0](https://github.com/serilog/serilog?tab=Apache-2.0-1-ov-file#readme)|
|[FluentValidation](https://github.com/FluentValidation/FluentValidation)|12.0.0|[Apache-2.0](https://github.com/FluentValidation/FluentValidation?tab=Apache-2.0-1-ov-file#readme)|
|[Mapperly](https://github.com/riok/mapperly)|4.3.1|[Apache-2.0](https://github.com/riok/mapperly?tab=Apache-2.0-1-ov-file#readme)|
|[WolverineFx](https://github.com/JasperFx/wolverine)|5.9.2|[MIT](https://github.com/JasperFx/wolverine?tab=MIT-1-ov-file#readme)|

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

Project link: [https://github.com/muhirwanto-dev/scarecrow/tree/main/src/Scarecrow.Clean](https://github.com/muhirwanto-dev/scarecrow/tree/main/src/Scarecrow.Clean)
