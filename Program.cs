using EmployeeManagementPKAPI.Data;
using EmployeeManagementPKAPI.Repositories;
using EmployeeManagementPKAPI.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);



// Register Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString(
            "DefaultConnection")));


builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddScoped<IEmployeeService, EmployeeServices>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowEmployeeUI", policy =>
    {
        policy
            .WithOrigins("https://localhost:7099")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});



builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors("AllowEmployeeUI");

// Enable Swagger in Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
