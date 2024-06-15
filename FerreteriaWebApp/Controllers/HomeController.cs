using FerreteriaWebApp.Models;
using FerreteriaWebApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FerreteriaWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBSISTEMA_VENTAContext _dbContext;
        //private readonly ILogger<HomeController> _logger;

        public HomeController(DBSISTEMA_VENTAContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            CardsDashboard cards = new CardsDashboard();
            cards.cantidadProductos = _dbContext.Productos.Count();
            cards.cantidadClientes = _dbContext.Clientes.Count();
            cards.cantidadVentas = _dbContext.Venta.Count();
            List<Producto> products = _dbContext.Productos.Where(p => p.Stok < 10 && p.Estado == true).OrderBy(p => p.Stok).Take(10).ToList();
            products.ForEach(p => cards.oProductos.Add(p));
            DateTime fechaActual = DateTime.Now;
            DateTime fechaInicial = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day, 00, 00, 00);
            List<DetalleVenta> detalles = _dbContext.DetalleVenta.Where(dv => dv.FechaRegistro >= fechaInicial && dv.FechaRegistro <= fechaActual).Include(v => v.IdVentaNavigation).Include(p => p.IdProductoNavigation).OrderBy(dv => dv.FechaRegistro).ToList();
            detalles.ForEach(dv => cards.oDetallesVentas.Add(dv));




            return View(cards);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
