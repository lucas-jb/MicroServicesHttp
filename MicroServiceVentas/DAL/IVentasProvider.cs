using MicroServiceVentas.Models;

namespace MicroServiceVentas.DAL
{
    public interface IVentasProvider
    {
        Task<ICollection<Venta>> GetAsync(string clienteId);
    }
}
