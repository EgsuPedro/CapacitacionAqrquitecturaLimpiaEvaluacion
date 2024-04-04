using Infraestructure;
using ApplicationCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hellow, Wordl");

var services = new ServiceCollection();
var configuration = new ConfigurationBuilder().Build();

Dependencias.ConfigureServices(services, configuration);

services.AddScoped<IProductoRespository, ProductoRepository>();

var serviceProvider = services.BuildServiceProvider();

var productoRepository = serviceProvider.GetService<IProductoRespository>();

var productos = productoRepository.ObtenerTodosLosProductos();

foreach (var producto in productos)
{
    Console.WriteLine($"Id: {producto.Id}, Nombre: {producto.Nombre},  Precio: {producto.Precio},  Descuento: {producto.Descuento}");
}