using Microsoft.AspNetCore.Mvc;
using appPolnice.Data;
using Microsoft.AspNetCore.Authorization;

namespace appPolnice.Controllers
{
    
    [Authorize(Roles = "A")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context){
            _context = context;
        }

        public IActionResult Producto(){
            return View();
        }

    }
}