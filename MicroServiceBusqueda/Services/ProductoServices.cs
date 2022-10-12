using MicroServiceBusqueda.Interfaces;
using MicroServiceBusqueda.Models;
using Newtonsoft.Json;

namespace MicroServiceBusqueda.Services
{
    public class ProductoServices : IProductosServices
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ProductoServices(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<Producto> GetAsync(string id)
        {
            var clienteHttp = _httpClientFactory.CreateClient("productoService");
            var respuesta = await clienteHttp.GetAsync($"api/productos/{id}");
            if (respuesta.IsSuccessStatusCode)
            {
                var content = await respuesta.Content.ReadAsStringAsync();
                var producto = JsonConvert.DeserializeObject<Producto>(content);
                return producto;
            }
            return null;
        }
    }
}
