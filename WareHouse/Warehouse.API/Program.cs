using Warehouse.API.BackgroundServices;
using Warehouse.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabase(builder.Configuration);
builder.Services.AddHostedService<DatabaseMigrateBackgroundService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
