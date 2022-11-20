using Microsoft.EntityFrameworkCore;
using RestaurantProject.DataLayer;
using RestaurantProject.Helpers;
using RestaurantProject.Interfaces.Repositories;
using RestaurantProject.Interfaces.Services;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IRestarauntService>();
builder.Services.AddScoped<IRestarauntRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RestarauntDbContext>(x => 
x.UseSqlServer(builder.Configuration.GetConnectionString("RestarauntDb")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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
