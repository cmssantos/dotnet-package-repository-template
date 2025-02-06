## dotnet-repository-template

#### Cms.AspNetCore.JsonLocalizer is a flexible and efficient JSON-based localization library for ASP.NET Core applications. It provides an easy way to manage and retrieve localized strings using JSON resource files, supporting culture-specific localization and seamless integration with dependency injection.

## Features

-   Feature One
-   Feature Two

## Installation

Install the package via NuGet:

```
dotnet add package Cms.AspNetCore.JsonLocalizer.Extensions
```

## Usage

### 1. Configure

In your Program.cs or Startup.cs, add the following:

```csharp
using Cms.AspNetCore.JsonLocalizer.Extensions;

// ...

services.AddJsonLocalizer(Path.Combine(Directory.GetCurrentDirectory(), "Resources"));

```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License.
