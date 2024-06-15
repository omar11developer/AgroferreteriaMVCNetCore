namespace FerreteriaWebApp.Models
{
    public partial class Permiso
    {
        public int IdPermiso { get; set; }
        public int? IdRol { get; set; }
        public string? NombreMenu { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual RolUsuario? IdRolNavigation { get; set; }
    }
}
