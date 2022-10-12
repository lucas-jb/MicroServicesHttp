using MicroServiceBusqueda.Models;

namespace MicroServiceBusqueda.Interfaces
{
    public interface IVentasServices
    {
        Task<ICollection<Venta>> GetAsync(string clienteId);
    }
}
