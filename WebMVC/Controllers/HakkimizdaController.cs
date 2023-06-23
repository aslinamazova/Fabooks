using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace WebMVC.Controllers;

public class HakkimizdaController : Controller
{

    public IActionResult BizKimiz()
    {
        return View();
    }
    public IActionResult Blog()
    {
        return View();
    }
    public IActionResult İletişim()
    {
        return View();
    }

}

