namespace MicroServiceBusqueda.Models
{
    public class Venta
    {
        public string Id { get; set; }
        public DateTime DateVenta { get; set; }
        public string ClienteId { get; set; }
        public double Total { get; set; }

        public List<ElementosVentas> Elementos { get; set; }
    }
}
