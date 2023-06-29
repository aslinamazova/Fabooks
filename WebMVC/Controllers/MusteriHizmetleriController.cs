using Microsoft.AspNetCore.Mvc;


namespace WebMVC.Controllers;

public class MusteriHizmetleriController : Controller
{
    public IActionResult KargoTeslimatKoşulları()
    {
        return View();
    }
    public IActionResult MesafeliSatışSözleşmesi()
    {
        return View();
    }
    public IActionResult GizlilikSözleşmesi()
    {
        return View();
    }

    public IActionResult SiparişDurumu()
    {
        return View();
    }
}

