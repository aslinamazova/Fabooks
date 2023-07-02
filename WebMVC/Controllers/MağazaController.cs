using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebMVC.Controllers;

public class MağazaController : Controller
{
    private readonly AppDbContext _dbContext;

    public MağazaController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> Planlayıcılar(int take)
    {
        List<Product> products = await _dbContext.Products
            .Where(p => !p.IsDeleted)
            .OrderByDescending(p => p.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImage)
            .ToListAsync();
        return View(products);
    }
    public async Task<IActionResult> Ajandalar(int take)
    {
        List<Product> products = await _dbContext.Products
            .Where(p => !p.IsDeleted)
            .OrderByDescending(p => p.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImage)
            .ToListAsync();
        return View(products);
    }
    public async Task<IActionResult> Defterler(int take)
    {
        List<Product> products = await _dbContext.Products
            .Where(p => !p.IsDeleted)
            .OrderByDescending(p => p.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImage)
            .ToListAsync();
        return View(products);
    }
    public async Task<IActionResult> Günlükler(int take)
    {
        List<Product> products = await _dbContext.Products
            .Where(p => !p.IsDeleted)
            .OrderByDescending(p => p.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImage)
            .ToListAsync();
        return View(products);
    }

    public async Task<IActionResult> Posterler(int take)
    {
        List<Product> products = await _dbContext.Products
            .Where(p => !p.IsDeleted)
            .OrderByDescending(p => p.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImage)
            .ToListAsync();
        return View(products);
    }
    public async Task<IActionResult> Takvimler(int take)
    {
        List<Product> products = await _dbContext.Products
            .Where(p => !p.IsDeleted)
            .OrderByDescending(p => p.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImage)
            .ToListAsync();
        return View(products);
    }
    public async Task<IActionResult> Bloknotlar(int take)
    {
        List<Product> products = await _dbContext.Products
            .Where(p => !p.IsDeleted)
            .OrderByDescending(p => p.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImage)
            .ToListAsync();
        return View(products);
    }
    public async Task<IActionResult> Yeni(int take)
    {
        List<Product> products = await _dbContext.Products
            .Where(p => !p.IsDeleted)
            .OrderByDescending(p => p.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImage)
            .ToListAsync();
        return View(products);
    }

    public async Task<IActionResult> Outlet(int take)
    {
        List<Product> products = await _dbContext.Products
            .Where(p => !p.IsDeleted)
            .OrderByDescending(p => p.Id)
            .Take(take)
            .Include(p => p.Category)
            .Include(p => p.ProductImage)
            .ToListAsync();
        return View(products);
    }
    
}

