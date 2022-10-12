using MicroServiceProductos.Models;

namespace MicroServiceProductos.DAL
{
    public interface IProductosProvider
    {
        Task<Producto> GetAsync(string id);
    }
}
