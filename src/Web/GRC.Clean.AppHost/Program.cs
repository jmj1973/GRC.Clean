var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.GRC_Blazor>("grc-blazor");       

builder.Build().Run();
