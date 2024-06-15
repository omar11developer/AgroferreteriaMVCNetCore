using FerreteriaWebApp.Models;
using FerreteriaWebApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Usuario_Detalle(int idUsuario)
        {
            UsuarioMV usuario = new UsuarioMV()
            {

                oUsuario = new Usuario(),
                oListaRoles = _dbContext.Rols.Select(roles => new SelectListItem()
                {
                    Text = roles.Descripcion,
                    Value = roles.IdRol.ToString()
                }).ToList(),


            };
            if (idUsuario != 0)
            {
                usuario.oUsuario = _dbContext.Usuarios.Find(idUsuario);
            }
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Usuario_Detalle(UsuarioMV usuarioMV)
        {

            if (usuarioMV.oUsuario.IdUsuario == 0)
            {
                _dbContext.Usuarios.Add(usuarioMV.oUsuario);
            }
            else
            {
                DateTime fechaActual = DateTime.Now;
                usuarioMV.oUsuario.FechaRegistro = fechaActual;
                _dbContext.Usuarios.Update(usuarioMV.oUsuario);
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Usuario");

        }
        [HttpGet]
        public IActionResult Eliminar_Usuario(int idUsuario)
        {
            Usuario oUsuario = _dbContext.Usuarios.Include(r => r.IdRolNavigation).Where(u => u.IdUsuario == idUsuario).FirstOrDefault();
            return View(oUsuario);
        }
        [HttpPost]
        public IActionResult Eliminar_Usuario(Usuario oUsuario)
        {
            _dbContext.Usuarios.Remove(oUsuario);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Usuario");
        }
        private IActionResult ModalController(ModalDetalle detalle)
        {
            throw new NotImplementedException();
        }
    }
}
