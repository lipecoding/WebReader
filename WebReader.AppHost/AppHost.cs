var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WebReader_API>("webreader-api");

builder.Build().Run();
