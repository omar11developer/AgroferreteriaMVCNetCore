namespace FerreteriaWebApp.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Compras = new HashSet<Compra>();
            Venta = new HashSet<Venta>();
        }

        public int IdUsuario { get; set; }
        public string? Documento { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public int? IdRol { get; set; }
        public bool Estado { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual RolUsuario? IdRolNavigation { get; set; }
        public virtual ICollection<Compra> Compras { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
