using M1S09ExercicioSemana9.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//string connectionString = "Server=DESKTOP-GKSG8G3\\SQLEXPRESS01;database=Semana;Trusted_Connection=True;TrustServerCertificate=True";
//
string connectionString = "Server=(localdb)\\.;database=Semana;";
builder.Services.AddDbContext<SemanaContext>(o=>o.UseSqlServer(connectionString));
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
