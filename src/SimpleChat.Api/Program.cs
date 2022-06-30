using Prism.Modularity;
using SimpleChat.Api.Extensions;
using SimpleChat.Di.Modules;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureContainer<IModuleCatalog>(
    catalog => catalog.AddModule<ApiDiModule>());

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCustomSqliteContext(builder.Configuration);

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
