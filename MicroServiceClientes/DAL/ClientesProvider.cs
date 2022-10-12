using MicroServiceClientes.Models;

namespace MicroServiceClientes.DAL
{
    public class ClientesProvider : IClientesProvider
    {
        private readonly List<Cliente> ClientesRepository = new List<Cliente>();

        public ClientesProvider()
        {
            ClientesRepository.Add(new Cliente() { Id = "1", Name = "Lucas", City = "Logroño" });
            ClientesRepository.Add(new Cliente() { Id = "2", Name = "Juan", City = "Madrid" });
            ClientesRepository.Add(new Cliente() { Id = "3", Name = "Jacinto", City = "Zaragoza" });
            ClientesRepository.Add(new Cliente() { Id = "4", Name = "Daniel", City = "Barcelona" });
            ClientesRepository.Add(new Cliente() { Id = "5", Name = "Sergio", City = "Valencia" });
            ClientesRepository.Add(new Cliente() { Id = "6", Name = "David", City = "Burgos" });
            ClientesRepository.Add(new Cliente() { Id = "7", Name = "Pablo", City = "Vigo" });
            ClientesRepository.Add(new Cliente() { Id = "8", Name = "Pedro", City = "Sevilla" });
        }
        public Task<Cliente> GetAsync(string id)
        {
            var cliente = ClientesRepository.FirstOrDefault(c => c.Id == id);
            return Task.FromResult(cliente);
        }
    }
}
