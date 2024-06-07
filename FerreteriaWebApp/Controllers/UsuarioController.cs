using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FerreteriaWebApp.Models.ViewModels;
using FerreteriaWebApp.Models;

namespace FerreteriaWebApp.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DBSISTEMA_VENTAContext _dbContext;

        public UsuarioController(DBSISTEMA_VENTAContext context)
        {
            _dbContext = context;
        }
        public IActionResult Index()
        {
           List<Usuario> list = _dbContext.Usuarios.Include(r => r.IdRolNavigation).ToList();
            
            return View(list);
        }
    }
}
