using MicroServiceClientes.Models;

namespace MicroServiceClientes.DAL
{
    public interface IClientesProvider
    {
        Task<Cliente> GetAsync(string id);
    }
}
