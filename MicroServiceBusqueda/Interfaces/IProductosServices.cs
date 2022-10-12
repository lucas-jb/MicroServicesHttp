using MicroServiceBusqueda.Models;

namespace MicroServiceBusqueda.Interfaces
{
    public interface IProductosServices
    {
        Task<Producto> GetAsync(string id);
    }
}
