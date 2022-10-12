using MicroServiceBusqueda.Interfaces;
using MicroServiceBusqueda.Services;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<IClientesServices, ClienteServices>();
builder.Services.AddSingleton<IProductosServices, ProductoServices>();
builder.Services.AddSingleton<IVentasServices, VentaServices>();

builder.Services.AddHttpClient("clienteService", c =>
{
    c.BaseAddress = new Uri(configuration["Services:Clientes"]);
});
builder.Services.AddHttpClient("productoService", c =>
{
    c.BaseAddress = new Uri(configuration["Services:Productos"]);
});
builder.Services.AddHttpClient("ventaService", c =>
{
    c.BaseAddress = new Uri(configuration["Services:Ventas"]);
});

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
