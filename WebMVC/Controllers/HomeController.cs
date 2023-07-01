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
            .OrderByDescending(p => p.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImage)
            .ToListAsync();
        
        foreach (var product in products)
        {
            product.DiscountedPrice = ApplyDiscount(product.Price, product.DiscountPercent);
        }
        return View(products);
    }

    private decimal ApplyDiscount(decimal price, int? discountPercent)
    {
        if (discountPercent.HasValue)
        {
            decimal discountAmount = Math.Round(price * ((decimal)discountPercent / 100), 2);
            decimal discountedPrice = price - discountAmount;
            return (discountedPrice);
        }
        else
        {
            return price;
        }
    }





}

