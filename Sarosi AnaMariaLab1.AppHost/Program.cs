var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Sarosi_AnaMariaLab1_ApiService>("apiservice");

builder.AddProject<Projects.Sarosi_AnaMariaLab1_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
