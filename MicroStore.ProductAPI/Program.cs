using Microsoft.EntityFrameworkCore;
using MicroStore.ProductAPI.Context;
using MicroStore.ProductAPI.Contracts;
using MicroStore.ProductAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var stringConnection = "Server=DESKTOP-N3AACJ8;Database=MicroStore.Product;Trusted_Connection=True;";
builder.Services.AddDbContext<BaseContext>(options => options.UseSqlServer(stringConnection));
builder.Services.AddScoped<IProductService, ProductService>();

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
