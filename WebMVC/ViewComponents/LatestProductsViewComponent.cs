
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebMVC.ViewComponents;

public class LatestProductsViewComponent:ViewComponent
{
    private readonly AppDbContext _context;

    public LatestProductsViewComponent(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        List<Product> products=await _context.Products
                                                    .Where(p=>!p.IsDeleted)
                                                    .OrderByDescending(p=>p.Id)
                                                    .Include(p=>p.ProductImage)
                                                    .ToListAsync();
        return await Task.FromResult( View(products));
    }
}
