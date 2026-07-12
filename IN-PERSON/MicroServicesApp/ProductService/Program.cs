using Microsoft.EntityFrameworkCore;
using ProductService;
using ProductService.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//// In-Memory Veritabanýný ekliyoruz
//builder.Services.AddDbContext<ProductDbContext>(options => options.UseInMemoryDatabase("ProductDb"));


//var connectionString = builder.Configuration.GetConnectionString("ProductDb");
builder.Services.AddDbContext<ProductDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ProductDb")));



// Swagger'ý servislere ekliyoruz
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
// Swagger arayüzünü aktif ediyoruz (Uygulama çalýþýrken tarayýcýda göstermek için)
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

// Servisimizin http://localhost:5001 adresinde çalýþmasýný saðlýyoruz
app.Run("http://localhost:5001");