using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FerreteriaWebApp.Models.ViewModels;
using FerreteriaWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        [HttpGet]
        public IActionResult Usuario_Detalle(int idUsuario) { 
            UsuarioMV usuario = new UsuarioMV()
            {
                
                oUsuario = new Usuario(),
                oListaRoles = _dbContext.Rols.Select(roles => new SelectListItem()
                {
                    Text = roles.Descripcion,
                    Value = roles.IdRol.ToString()
                }).ToList(),
               
           
            };
            if(idUsuario != 0)
            {
                usuario.oUsuario = _dbContext.Usuarios.Find(idUsuario);
            }
          return View(usuario);
        }
        [HttpPost]
        public IActionResult Usuario_Detalle(UsuarioMV usuarioMV)
        {
            if (usuarioMV.oUsuario == null) {
                ModalDetalle detalle = new ModalDetalle()
                {
                    titulo = "Usuario",
                    detalle = "No se encontro ninun usuario",
                    direccion="Index",
                    controller = "Usuario"
                };
               return ModalController(detalle);
            }
            if (usuarioMV.oUsuario.IdUsuario == 0) { 
                _dbContext.Usuarios.Add(usuarioMV.oUsuario);
            }
            else
            {
                _dbContext.Usuarios.Update(usuarioMV.oUsuario);
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Usuario");
        }

        private IActionResult ModalController(ModalDetalle detalle)
        {
            throw new NotImplementedException();
        }
    }
}
