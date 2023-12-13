var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WebApplicationDemo>("WebApplicationDemo");

builder.AddProject<Projects.BlazorAppWeb>("BlazorAppWeb");

builder.Build().Run();
