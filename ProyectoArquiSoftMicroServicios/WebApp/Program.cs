using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApp.Clases;

var builder = WebApplication.CreateBuilder(args);

// Configurar servicios
builder.Services.AddControllers(); // Si necesitas controladores
builder.Services.AddHttpClient(); // Registrar HttpClient
builder.Services.AddScoped<Proxy>();  // Registrar el servicio Proxy
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();

app.MapControllers(); // Si estás usando controladores
app.MapFallbackToFile("/Views/index.html");

app.Run();
