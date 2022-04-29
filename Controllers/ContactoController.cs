using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace appPolnice.Controllers
{
    public class ContactoController: Controller
    {
        private readonly ILogger<HomeController> _logger;

    public ContactoController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Create()
    {
        return View("Index");
    }

    

    }
}