﻿namespace FerreteriaWebApp.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            Compras = new HashSet<Compra>();
        }

        public int IdProveedor { get; set; }
        public string? Documento { get; set; }
        public string? RazonSocial { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Compra> Compras { get; set; }
    }
}
