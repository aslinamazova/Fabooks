using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebMVC.Controllers
{
    public class HediyelerController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HediyelerController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Annemİçin(int take)
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
        public async Task<IActionResult> Arkadaşımİçin(int take)
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
        public IActionResult Babamİçin()
        {
            return View();
        }
        public async Task<IActionResult> Sevgililerİçin(int take)
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
        public async Task<IActionResult> TümHediyeler(int take)
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
        public async Task<IActionResult> Eglencemotivasyon(int take)
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
}

