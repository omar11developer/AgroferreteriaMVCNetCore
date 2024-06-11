using Microsoft.AspNetCore.Mvc.Rendering;

namespace FerreteriaWebApp.Models.ViewModels
{
    public class UsuarioMV
    {
        public Usuario? oUsuario { get; set; }
        public List<SelectListItem>? oListaRoles { get; set; }

    }
}
