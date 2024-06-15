namespace FerreteriaWebApp.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleCompras = new HashSet<DetalleCompra>();
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdProducto { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? IdCategoria { get; set; }
        public int Stok { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? PrecioVenta { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Categoria? IdCategoriaNavigation { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompras { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
