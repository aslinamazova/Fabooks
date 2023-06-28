using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebMVC.Controllers;

public class ProductsController : Controller
{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index(int take)
    {
        List<Product> products = await _context.Products
            .Where(p => !p.IsDeleted)
            .OrderByDescending(s => s.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImages)
            .ToListAsync();

        foreach (var product in products)
        {
            product.Discount = ApplyDiscount(product.Price, (decimal)product.Discount);
        }
        return View(products);
    }
    private decimal ApplyDiscount(decimal price, decimal discount)
    {
        // İndirim hesaplama mantığını burada uygulayın
        decimal discountedPrice = price - (price * (discount / 100));
        return discountedPrice;
    }

}

