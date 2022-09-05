using Autofac;
using Autofac.Extensions.DependencyInjection;

using SimpleChat.Api.Extensions;
using SimpleChat.Di.Modules;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(
    builder => builder.RegisterModule(new ApiDiModule()));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCustomSqliteContext(builder.Configuration);
builder.Services.AddCustomCorsPolicy(builder.Configuration);
builder.Services.AddCustomAutoMapper();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseCustomCorsPolicy();

app.UseAuthorization();

app.MapControllers();

app.Run();
