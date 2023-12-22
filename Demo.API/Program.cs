using Demo.BLL.Interfaces;
using Demo.BLL.Services;
using Demo.DAL.Interfaces;
using Demo.DAL.Repositories;
using Microsoft.VisualBasic;
using Tools;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Singletons
builder.Services.AddSingleton(sp => new Connection(builder.Configuration.GetConnectionString("default")));

// Repositories => Dal
builder.Services.AddScoped<IUtilisateurRepository, UtilisateurRepository>();

// Services => Bll
builder.Services.AddScoped<IUtilisateurService, UtilisateurService>();


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
