using Microsoft.AspNetCore.Mvc;

namespace FerreteriaWebApp.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
