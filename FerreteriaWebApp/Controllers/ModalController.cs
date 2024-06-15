using FerreteriaWebApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FerreteriaWebApp.Controllers
{
    public class ModalController : Controller
    {
        public IActionResult Modal(ModalDetalle detalle)
        {
            return View(detalle);
        }
    }
}
