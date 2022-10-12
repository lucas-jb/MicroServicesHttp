using MicroServiceProductos.Models;

namespace MicroServiceProductos.DAL
{
    public class ProductosProvider : IProductosProvider
    {
        private List<Producto> ProductosRepository = new List<Producto>();
        public ProductosProvider()
        {
            for (int i = 0; i < 100; i++)
            {
                ProductosRepository.Add(new Producto()
                {
                    Id = (i + 1).ToString(),
                    Nombre = $"Producto {i + 1}",
                    Precio = (double)i * Math.PI
                });
            }
        }
        public Task<Producto> GetAsync(string id)
        {
            var product = ProductosRepository.FirstOrDefault(p => p.Id == id);
            return Task.FromResult(product);
        }
    }
}
