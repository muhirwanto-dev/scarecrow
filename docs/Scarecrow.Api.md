# Scarecrow.Api

[![NuGet Version](https://img.shields.io/nuget/v/Scarecrow.Api.Template.svg?style=flat-square)](https://www.nuget.org/packages/Scarecrow.Api.Template/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Scarecrow.Api.Template.svg?style=flat-square)](https://www.nuget.org/packages/Scarecrow.Api.Template/)
[![License](https://img.shields.io/github/license/muhirwanto-dev/scarecrow?style=flat-square)](LICENSE)
[![GitHub Issues](https://img.shields.io/github/issues/muhirwanto-dev/scarecrow?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/issues)
[![GitHub Stars](https://img.shields.io/github/stars/muhirwanto-dev/scarecrow?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/stargazers)
[![GitHub Forks](https://img.shields.io/github/forks/muhirwanto-dev/scarecrow?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/network/members)
[![Contributions Welcome](https://img.shields.io/badge/Contributions-Welcome-brightgreen.svg?style=flat-square)](https://github.com/muhirwanto-dev/scarecrow/pulls)

## Overview

A **Web API template** built on top of **Scarecrow.Clean**. This template focuses on **delivery concerns** while keeping business logic isolated. It comes pre-configured with `Routing Convention`, `Logging` with `Serilog`, middleware integration for exception & logging handler, object mapping with `Mapperly`, and API versioning.

## Built On

- Scarecrow.Clean architecture
- ASP.NET Core (.NET 9 & 10)

---

## Features

- Kebab-case routing convention
- Serilog logging
- Exception & request logging middleware
- API versioning
- FluentValidation
- Mapperly
- OpenAPI / Swagger ready

## Installation

Install the template from Package Manager console:

**Package Manager Console:**

```powershell
dotnet new install Scarecrow.Api
```

**.NET CLI**
```bash
dotnet new install Scarecrow.Api
```

## When to Use This Template

- ✔ REST APIs
- ✔ Public or internal services
- ✔ HTTP-based integrations

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

Project link: [https://github.com/muhirwanto-dev/scarecrow/tree/main/src/Scarecrow.Api](https://github.com/muhirwanto-dev/scarecrow/tree/main/src/Scarecrow.Api)
