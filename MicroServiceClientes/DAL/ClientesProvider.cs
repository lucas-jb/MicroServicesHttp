using MicroServiceClientes.Models;

namespace MicroServiceClientes.DAL
{
    public class ClientesProvider : IClientesProvider
    {
        private readonly List<Cliente> repo = new List<Cliente>();

        public ClientesProvider()
        {
            repo.Add(new Cliente() { Id = "1", Name = "Lucas", City = "Logroño" });
            repo.Add(new Cliente() { Id = "2", Name = "Juan", City = "Madrid" });
            repo.Add(new Cliente() { Id = "3", Name = "Jacinto", City = "Zaragoza" });
            repo.Add(new Cliente() { Id = "4", Name = "Daniel", City = "Barcelona" });
            repo.Add(new Cliente() { Id = "5", Name = "Sergio", City = "Valencia" });
            repo.Add(new Cliente() { Id = "6", Name = "David", City = "Burgos" });
            repo.Add(new Cliente() { Id = "7", Name = "Pablo", City = "Vigo" });
            repo.Add(new Cliente() { Id = "8", Name = "Pedro", City = "Sevilla" });
        }
        public Task<Cliente> GetAsync(string id)
        {
            var cliente = repo.FirstOrDefault(c => c.Id == id);
            return Task.FromResult(cliente);
        }
    }
}
