using Ocelot.DependencyInjection;
using Ocelot.Middleware;
var builder = WebApplication.CreateBuilder(args);
// --- CORS ÝZNÝ EKLENÝYOR ---
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
// -----------------------------
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);
var app = builder.Build();
// Ocelot'tan hemen ÖNCE CORS'u devreye alýyoruz
app.UseCors("AllowAll");
await app.UseOcelot();
app.Run("http://localhost:5000");