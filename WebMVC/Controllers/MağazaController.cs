using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebMVC.Controllers
{
    public class MağazaController : Controller
    {
        public IActionResult Planlayıcılar()
        {
            return View();
        }
        public IActionResult Ajandalar()
        {
            return View();
        }
        public IActionResult Defterler()
        {
            return View();
        }
        public IActionResult Günlükler()
        {
            return View();
        }
        public IActionResult Posterler()
        {
            return View();
        }
        public IActionResult Takvimler()
        {
            return View();
        }
    }
}

