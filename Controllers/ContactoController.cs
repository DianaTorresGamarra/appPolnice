using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using appPolnice.Models;
using appPolnice.Data;


namespace appPolnice.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;
        

    public ContactoController(ApplicationDbContext context,
    ILogger<HomeController> logger)
    {
        _context = context;
        _logger = logger;
       
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Contacto objContacto)
    {
        _context.Add(objContacto);
        _context.SaveChanges();

        

        

        ViewData["Message"] = "Se registro el contacto";
        return View("Index");
    }

    }
}