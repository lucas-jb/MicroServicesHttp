using MicroServiceBusqueda.Models;

namespace MicroServiceBusqueda.Interfaces
{
    public interface IClientesServices
    {
        Task<Cliente> GetAsync(string id);
    }
}
