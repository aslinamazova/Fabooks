using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace WebMVC.Controllers;

public class AboutController : Controller
{
    private readonly AppDbContext _context;
    public AboutController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{Id}")]
    public async Task <IActionResult> Urun([FromRoute] int id)
    {
        Product? product = await _context.Products
                                            .Where(p => p.Id == id)
                                            .Include(p => p.Categories)
                                            .Include(p => p.ProductImage)
                                            .FirstOrDefaultAsync();
        if (product == null) return RedirectToAction("Index","Home");
        return View(product);
    }
}

