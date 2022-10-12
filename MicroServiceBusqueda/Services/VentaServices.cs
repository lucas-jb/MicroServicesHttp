using MicroServiceBusqueda.Interfaces;
using MicroServiceBusqueda.Models;
using Newtonsoft.Json;

namespace MicroServiceBusqueda.Services
{
    public class VentaServices : IVentasServices
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public VentaServices(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ICollection<Venta>> GetAsync(string clienteId)
        {
            var clienteHttp = _httpClientFactory.CreateClient("ventaService");
            var respuesta = await clienteHttp.GetAsync($"api/ventas/{clienteId}");
            if (respuesta.IsSuccessStatusCode)
            {
                var content = await respuesta.Content.ReadAsStringAsync();
                var ventas = JsonConvert.DeserializeObject<ICollection<Venta>>(content);
                return ventas;
            }
            return null;
        }
    }
}
