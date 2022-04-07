using System;
using Microsoft.EntityFrameworkCore;
using PurpleHardware;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var folder = Environment.SpecialFolder.LocalApplicationData;
var path = Environment.GetFolderPath(folder);
var connectionString = $"Data Source={System.IO.Path.Join(path, "PurpleHardware.db")}";

builder.Services.AddDbContext<ProductContext>(options =>{options.UseSqlite(connectionString);});
builder.Services.AddDbContext<UserContext>(options =>{options.UseSqlite(connectionString);});

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
