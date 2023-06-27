using System.Diagnostics;
using DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _dbContext;

    public HomeController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Urun()
    {
        return View();
    }
}

