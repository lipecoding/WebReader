var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WebReader_API>("webreader-api");

builder.AddProject<Projects.WebReader_Web>("webreader-web");

builder.Build().Run();
