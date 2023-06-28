using System.Diagnostics;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebMVC.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _dbContext;

    public HomeController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Index(int take=4)
    {
        List<Product> products = await _dbContext.Products
            .Where(p => !p.IsDeleted)
            .OrderByDescending(s => s.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImage)
            .ToListAsync();
        
        foreach (var product in products)
        {
            product.Discount = ApplyDiscount(product.Price, (decimal)product.Discount);
        }
        return View(products);
    }
    private decimal ApplyDiscount(decimal price, decimal discount)
    {
        decimal discountedPrice = price - (price * (discount / 100));
        return discountedPrice;
    }

}

