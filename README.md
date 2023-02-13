# GRC.Clean
 Use Visual Studio Code and .Net 6.0

## Visual Studio Code
 Microsoft Visual Studio Code (64-bit) - Current
 Version 1.74.3

## .Net 6.0
 Microsoft .NET SDK 6.0.405

## Running the code
 Check the gode out
 Open in Visual Studio
 Change appsettings.json to your SQL/SQLExpress DB


 ## Clean Architeture

``` 
  MVC - API - Application - Domain - Presisence - DB
  |       |   |                   |  |             |
  +-------+   +-------------------+  +-------------+
     Web              Core            Infrastructure
```
  MVC: (Web)

  API: (Web)

  Application: (Core)
  - DTOs
  - Command
  - Queries

  MediatR
  read Queries
  write Commands
  AutoMapper
  DTOs - Entities

  Domain: (Core)
  - Entities
  - Interfaces
  - Resouces

  Presistence: (Infrastructure)
  - Repositories
  - DBContext
  - Configurations(Seed)
  - Migrations

  Infrastructure (Infrastructure)


 ## Steps

 1. Create a blank soloution
    - Folder structure: src and tests
    ```
    dotnet new sln -o GRC.Clean.Clean
    cd GRC.Clean.Clean
    mkdir doc
    mkdir src
    mkdir test
    ```    

 2. Setup some Clean archtecture projects
    - GRC.CleanApplication (Core)
       Class Library .NET 6.0
       ```
       dotnet new classlib -f net6.0 -n GRC.Clean.Application -o src/Core/GRC.Clean.Application
       dotnet sln add src/Core/GRC.Clean.Application/GRC.Clean.Application.csproj
       dotnet add src/Core/GRC.Clean.Application package Microsoft.Extensions.DependencyInjection
       dotnet add src/Core/GRC.Clean.Application package Microsoft.Extensions.Configuration
       ```
    - GRC.Clean.Domain (Core)
       Class Library .NET 6.0
       ```
       dotnet new classlib -f net6.0 -n GRC.Clean.Domain -o src/Core/GRC.Clean.Domain
       dotnet sln add src/Core/GRC.Clean.Domain/GRC.Clean.Domain.csproj
       dotnet add src/Core/GRC.Clean.Domain package Microsoft.Extensions.DependencyInjection
       dotnet add src/Core/GRC.Clean.Domain package Microsoft.Extensions.Configuration
       ```       
    - GRC.CleanInfrastructure (Infrastructure)
       Class Library .NET 6.0
       ```
       dotnet new classlib -f net6.0 -n GRC.Clean.Infrastructure -o src/Infrastructure/GRC.Clean.Infrastructure
       dotnet sln add src/Infrastructure/GRC.Clean.Infrastructure/GRC.Clean.Infrastructure.csproj
       dotnet add src/Infrastructure/GRC.Clean.Infrastructure package Microsoft.Extensions.DependencyInjection
       dotnet add src/Infrastructure/GRC.Clean.Infrastructure package Microsoft.Extensions.Configuration

       ```              
    - GRC.Clean.Presistence (Infrastructure)
       Class Library .NET 6.0
       ```
       dotnet new classlib -f net6.0 -n GRC.Clean.Presistence -o src/Infrastructure/GRC.Clean.Presistence
       dotnet sln add src/Infrastructure/GRC.Clean.Presistence/GRC.Clean.Presistence.csproj
       dotnet add src/Infrastructure/GRC.Clean.Presistence package Microsoft.Extensions.DependencyInjection
       dotnet add src/Infrastructure/GRC.Clean.Presistence package Microsoft.Extensions.Configuration

       ```      
