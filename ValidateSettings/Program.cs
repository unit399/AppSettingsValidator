using FluentValidation;
using Microsoft.Extensions.Options;
using ValidateSettings;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

builder.Services.AddValidatorsFromAssemblyContaining<Program>(ServiceLifetime.Singleton);

builder.Services
    .AddOptions<TestOptions>()
    .Bind(config.GetSection(TestOptions.SectionName))
    .ValidateFluently();

var app = builder.Build();

app.MapGet("testEndpoint", (IOptions<TestOptions> opt) => opt.Value);

app.Run();
 