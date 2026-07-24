using Auth.Application;
using Auth.Application.Abstraction;
using Auth.Application.Dtos.Register;
using Auth.Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddEndpointsApiExplorer();
services.AddValidation();
services.AddOpenApi("v1");

services.AddServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

var apiGroup = app.MapGroup(@"/auth/api/v1");

apiGroup.MapPost(@"register", async (
    [FromServices] IRegisterService service,
    [FromBody] RegisterDto register,
    CancellationToken token) => 
{
    HashedPassport hashedPassport = await service.HashPassportAsync(
        register.Passport, 
        token
    );

    //var result = await service.TryToRegister(
    //    register.FullName,
    //    hashedPassport, 
    //    token
    //);

    //if (result.IsFailure)
    //    return Results.NotFound();

    //return Results.Ok(result.Value);

    return Results.Ok();
});

app.Run();
