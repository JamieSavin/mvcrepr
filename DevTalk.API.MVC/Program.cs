using DevTalk.Contracts.Commands;
using DevTalk.Infrastructure.Extensions;
using Serilog;
using System.Reflection;

List<Assembly> mediatRAssemblies = [typeof(Program).Assembly, typeof(CreateDevSpeakerCommand).Assembly];


var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterInfra();

builder.Host.UseSerilog((context, loggerConfig) => { loggerConfig.ReadFrom.Configuration(context.Configuration); });

// Add services to the container.

builder.Services.AddMediatR(cfg =>
cfg.RegisterServicesFromAssemblies([.. mediatRAssemblies]));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSerilogRequestLogging();

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
