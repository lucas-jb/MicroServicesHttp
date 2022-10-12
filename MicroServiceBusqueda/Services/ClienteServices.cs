using MicroServiceBusqueda.Interfaces;
using MicroServiceBusqueda.Models;
using Newtonsoft.Json;

namespace MicroServiceBusqueda.Services
{
    public class ClienteServices : IClientesServices
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ClienteServices(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<Cliente> GetAsync(string id)
        {
            var clienteHttp = _httpClientFactory.CreateClient("clienteService");

            var respuesta = await clienteHttp.GetAsync($"api/clientes/{id}");

            if (respuesta.IsSuccessStatusCode)
            {
                var content = await respuesta.Content.ReadAsStringAsync();
                var cliente = JsonConvert.DeserializeObject<Cliente>(content);
                return cliente;
            }

            return null;
        }
    }
}
