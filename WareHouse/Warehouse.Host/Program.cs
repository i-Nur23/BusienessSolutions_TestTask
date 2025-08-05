using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var postgresDb = builder
    .AddPostgres("postgresql")
    .AddDatabase("warehousedb");

builder
    .AddProject<Warehouse_API>("API")
    .WithReference(postgresDb);

builder.Build().Run();
