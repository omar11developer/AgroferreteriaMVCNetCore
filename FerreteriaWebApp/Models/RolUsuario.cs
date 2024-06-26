﻿namespace FerreteriaWebApp.Models
{
    public partial class RolUsuario
    {
        public RolUsuario()
        {
            Permisos = new HashSet<Permiso>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Permiso> Permisos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
