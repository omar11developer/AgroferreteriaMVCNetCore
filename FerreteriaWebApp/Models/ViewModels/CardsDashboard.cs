namespace FerreteriaWebApp.Models.ViewModels
{
    public class CardsDashboard
    {
        public int cantidadProductos { get; set; }
        public int cantidadVentas { get; set; }
        public int cantidadClientes { get; set; }

       public List<Producto> oProductos = new List<Producto>();
        public List<DetalleVenta> oDetallesVentas = new List<DetalleVenta>();

    }
}
