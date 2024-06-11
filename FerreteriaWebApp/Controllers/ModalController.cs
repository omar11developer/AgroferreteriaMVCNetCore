using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FerreteriaWebApp.Models.ViewModels;
using FerreteriaWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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
