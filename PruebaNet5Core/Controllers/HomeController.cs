using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNet5Core.Controllers
{
    public class HomeController : Controller
    {
    
        public ViewResult Index()
        {
            ViewBag.Dato = "Saludos desde la vista";
            return View();
        }

    }
}
