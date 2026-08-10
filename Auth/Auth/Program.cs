using Auth.Application;
using Auth.Application.Abstraction;
using Auth.Application.Dtos.Register;
using Auth.Domain.ValueObjects;
using Auth.Infrastructure.DataAccess;
using Auth.Infrastructure.DataAccess.DataAccess;
using Auth.Infrastructure.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddEndpointsApiExplorer();
services.AddValidation();
services.AddOpenApi("v1");

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
    
    services.AddDbServices(app.Configuration.GetRequiredSection("ConnectionStrings"));
}


services.AddApplicationServices();
services.AddSecurityServices();

var apiGroup = app.MapGroup(@"/auth/api/v1");

apiGroup.MapPost(@"register", async (
    [FromServices] IRegisterService service,
    [FromBody] RegisterDto register,
    CancellationToken token) => 
{
    var result = await service.TryToRegister(
        register.FullName,
        register.Passport,
        token);

    return Results.Ok(result);
});

using ( var  scope = app.Services.CreateScope() )
{
    var migrator =  scope.ServiceProvider.GetRequiredService<IMigrationBuilder>();

    await migrator.MigrateAsync();
}

app.Run();
