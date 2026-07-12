using Microsoft.EntityFrameworkCore;
using CustomerService;
using CustomerService.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//// In-Memory Veritabanýný ekliyoruz
//builder.Services.AddDbContext<CustomerDbContext>(options => options.UseInMemoryDatabase("CustomerDb"));
var connectionString = builder.Configuration.GetConnectionString("CustomerDb");
builder.Services.AddDbContext<CustomerDbContext>(options =>
    options.UseSqlServer(connectionString));




// Swagger'ý servislere ekliyoruz
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
// Swagger arayüzünü aktif ediyoruz (Uygulama çalýþýrken tarayýcýda göstermek için)
app.UseSwagger();
app.UseSwaggerUI();






app.MapControllers();

// Servisimizin http://localhost:5002 adresinde çalýþmasýný saðlýyoruz
app.Run("http://localhost:5002");