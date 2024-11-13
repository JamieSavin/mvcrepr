using DevTalk.Contracts.Commands;
using DevTalk.Infrastructure.Extensions;
using FastEndpoints;
using FastEndpoints.Swagger;
using Serilog;
using System.Reflection;

List<Assembly> mediatRAssemblies = [typeof(Program).Assembly, typeof(CreateDevSpeakerCommand).Assembly];

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(cfg =>
cfg.RegisterServicesFromAssemblies([.. mediatRAssemblies]));


builder.Services.RegisterInfra();

builder.Services.AddFastEndpoints().SwaggerDocument(o =>
{
    o.ShortSchemaNames = true;
});

builder.Host.UseSerilog((context, loggerConfig) => { loggerConfig.ReadFrom.Configuration(context.Configuration); });

var app = builder.Build();

app.UseSerilogRequestLogging();

app.UseFastEndpoints().UseSwaggerGen();

app.Run();
