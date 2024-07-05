using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Entities;
using Data;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Configure DbContext
builder.Services.AddDbContext<DataContext>(options =>
{
    var configuration = builder.Configuration;

    var sqlServerUser = configuration["SQLSERVER_USER"] ?? "SA";
    var sqlServerPassword = configuration["SQLSERVER_PASSWORD"] ?? "YourStrongPassword123!";
    var sqlServerPort = configuration["SQLSERVER_PORT"] ?? "1433";
    var sqlServerDatabase = configuration["DATABASE"] ?? "strawpoll";
    var sqlServerHostname = configuration["SQLSERVER_HOST"] ?? "localhost";

    var connectionString = $"Server={sqlServerHostname},{sqlServerPort};Database={sqlServerDatabase};User Id={sqlServerUser};Password={sqlServerPassword};TrustServerCertificate=True;";

    options.UseSqlServer(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();