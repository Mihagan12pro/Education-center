using Auth.Application.Dtos;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var apiGroup = app.MapGroup(@"auth\api");

apiGroup.MapPost("register", async (
    [FromForm] RegisterDto register,
    CancellationToken token) => 
{

});

app.Run();
