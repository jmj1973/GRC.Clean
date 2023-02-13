# Steps

```
dotnet add src/Core/GRC.Clean.Application package Microsoft.Extensions.
DependencyInjection
dotnet add src/Core/GRC.Clean.Application package Microsoft.Extensions.
Configuration       
dotnet add src/Core/GRC.Clean.Application package AutoMapper.Extensions.
Microsoft.DependencyInjection
dotnet add src/Core/GRC.Clean.Application package MediatR.Extensions.Microsoft.
DependencyInjection
```      
   
   - DTOs\Common\BaseDto.cs
   - Features\X\Handlers\Commands
   - Features\X\Handlers\Queries
   - Features\X\Requests\Commands
   - Features\X\Requests\Queries
   - Profiles\MappingProfile.cs


4.1. Create the Application Services Registration

   - ApplicationServicesRegistration.cs

4.2. Add the Domain reference project

   ```
   dotnet add src/Core/GRC.Clean.Application reference src/Core/GRC.Clean.Domain/GRC.Clean.Domain.csproj
   ```
   
4.3. Create the BaseDto
    
    - DTOs\Common\BaseDto.cs

    ```
        public abstract class BaseDto<TType>
        {
            public TType Id { get; set; }
        }
    ```



Request carries a DTO
DTO needs to be mapped to Entity 

QueryResultDto
```
    public class PageResultDto
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
    }
    public class QueryResultDto<TDto>
    {
        public PageResultDto Page { get; set; }
        public IEnumerable<TDto> PageItems { get; set; }
    }
```