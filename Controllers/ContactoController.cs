using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using appPolnice.Models;
using appPolnice.Data;

namespace appPolnice.Controllers
{
    public class ContactoController: Controller
    {
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context;

    public ContactoController(ApplicationDbContext context, 
    ILogger<ContactoController> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
     public IActionResult Create(Contactos objContactos)
     
    {
        _context.Add(objContactos);
        _context.SaveChanges();
        ViewData["Message"] = "Se registro el contacto";
        return View("Index");
    }

  
    }
}