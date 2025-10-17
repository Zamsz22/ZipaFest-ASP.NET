using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ZipaFest.Models;

namespace ZipaFest.Controllers
{
    public class HomeController : Controller
    {
        // Página principal
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        // Sobre nosotros
        public IActionResult AboutUs()
        {
            return View("~/Views/Home/AboutUs.cshtml");
        }

        // Contacto
        public IActionResult Contact()
        {
            return View("~/Views/Home/Contact.cshtml");
        }

        // Burger Fest
        public IActionResult Burger()
        {
            return View("~/Views/Home/Burger.cshtml");
        }

        // Torta Fest
        public IActionResult Cake()
        {
            return View("~/Views/Home/Cake.cshtml");
        }

        // Coffee Master
        public IActionResult Coffee()
        {
            return View("~/Views/Home/Coffee.cshtml");
        }

        // Empanada Fest
        public IActionResult Empanada()
        {
            return View("~/Views/Home/Empanada.cshtml");
        }

        // Pizza Fest
        public IActionResult Pizza()
        {
            return View("~/Views/Home/Pizza.cshtml");
        }

        // Rewards (cupones)
        public IActionResult Rewards()
        {
            
            return View("~/Views/Home/Rewards.cshtml");
        }

        // Manejo de errores
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml",
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
