﻿using System;
using System.Collections.Generic;

namespace FerreteriaWebApp.Models
{
    public partial class Permiso
    {
        public int IdPermiso { get; set; }
        public int? IdRol { get; set; }
        public string? NombreMenu { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Rol? IdRolNavigation { get; set; }
    }
}
