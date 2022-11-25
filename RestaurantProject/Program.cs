using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using RestaurantProject.DataLayer;
using RestaurantProject.Helpers;
using RestaurantProject.Interfaces.Repositories;
using RestaurantProject.Interfaces.Services;
using RestaurantProject.Repositories;
using RestaurantProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IRestarauntRepository, RestarauntRepository>();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<IRestarauntService, RestarauntService>();
builder.Services.AddAutoMapper(typeof(RestarauntMapperProfile));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(x => 
x.UseSqlServer(builder.Configuration.GetConnectionString("RestarauntDb")));
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
app.UseExceptionHandler(a => a.Run(async context =>
{
    var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
    var exception = exceptionHandlerPathFeature.Error;
    await context.Response.WriteAsJsonAsync(new { error = exception.Message });
}));
app.Run();
