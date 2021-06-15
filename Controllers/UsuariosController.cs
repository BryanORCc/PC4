using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PC4.Models;

namespace PC4.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly PC4Context _context;

        public UsuariosController(PC4Context context){
            _context = context;
        }

        public IActionResult Usuario(){
            return View();
        }

        [HttpPost]
        public IActionResult Usuario(Usuario u){
            if(ModelState.IsValid){
                _context.Add(u);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(u);
        }

        
    }
}