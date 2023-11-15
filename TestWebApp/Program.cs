using CompanyName.Modules.ModuleA.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddModuleA();

var app = builder.Build();

app.MapGet("/", () => "pong!");
app.Run();
