# BlackSlope-slim.NET

## What is it?

This is a fork of [Blackslope.net](https://github.com/SlalomBuild/blackslope.net) with the tests, Active Directory, Entity Framework, and Auth Token tools removed.

## Installation Instructions

### Install .NET Core

Install the latest verison of .NET Core for Windows/Linux or Mac.

- <https://dotnet.microsoft.com/download>

### Build (Application)

dotnet build src/BlackSlope.NET.sln

### Run

dotnet run --project src/BlackSlope.Api/BlackSlope.Api.csproj

### Test

    dotnet test ./src/

### Swagger

Open your browser and navigate to `http://localhost:51385/swagger` to view the API documentation

### StyleCop and NetAnalyzers

Two different analyzers are used to keep the codebase clean and formatted.

1. StyleCop - for style formatting and code cleanliness
   - Consumes `stylecop.json` files at the project level
   - May be set as part of `.editorconfig`, but documentation is sparse and not recommended at this time
2. Microsoft.CodeAnalysis.NetAnalyzers - Nuget package for the IDE level; covers style formatting and code analysis issues.
   - Consumes `.editorconfig` files set at the solution or project level

**NOTE:** SA and CA rules are globally suppressed at `BlackSlope.Api.Common.GlobalSuppressions`

- [.editorconfig Configuration](https://github.com/dotnet/roslyn-analyzers/blob/main/docs/Analyzer%20Configuration.md)
- [stylecop.json Configuration](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/documentation/Configuration.md)

**StyleCop**  
The following rules are currently ignored:

| Rule Id | Rule Title                                        |
| ------- | ------------------------------------------------- |
| SA1101  | Prefix local calls with this                      |
| SA1309  | Field names should not begin with an underscore   |
| SA1600  | Elements should be documented                     |
| SA1614  | Element parameter documentation must have text    |
| SA1616  | Element return value documentation must have text |
| SA1629  | Documentation text should end with a period       |
| SA1633  | File should have header                           |

**CodeAnalysis**  
The following rules are currently ignored:

| Rule Id | Rule Title                             | Scope                                                                                                                                                           |
| ------- | -------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| CA1031  | Do not catch general exception types   | `~M:BlackSlope.Api.Common.Middleware.ExceptionHandling.ExceptionHandlingMiddleware.Invoke(Microsoft.AspNetCore.Http.HttpContext)~System.Threading.Tasks.Task")` |
| CA1710  | Identifiers should have correct suffix | `` ~T:BlackSlope.Api.Common.Validators.CompositeValidator\`1 ``                                                                                                 |
