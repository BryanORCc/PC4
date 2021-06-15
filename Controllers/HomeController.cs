using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC4.Models;

namespace PC4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PC4Context _context;
        public static string ID;

        public HomeController(ILogger<HomeController> logger, PC4Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var usuario = _context.DataUsuarios.ToList();
            return View(usuario);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login l){
            var usuario = _context.DataUsuarios.Where(x => x.UsuarioId.Equals(l.id));

            if(usuario.Count()!=0){
                ID = l.id;
                return Redirect("/Usuarios/Publicar/ID");
            }
            else{
                ViewData["m"] = "Id o Contraseña incorrecta";
                return View("Login");
            }
        }

        public IActionResult Logeado()
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
