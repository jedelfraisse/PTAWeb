var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.PTAHub_ApiService>("apiservice");

builder.AddProject<Projects.PTAHub_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
