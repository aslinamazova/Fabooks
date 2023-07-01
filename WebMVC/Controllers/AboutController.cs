using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMVC.ViewModels.Basket;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebMVC.Controllers;

public class AboutController : Controller
{
    private readonly AppDbContext _context;
    private const string COOKIES_BASKET = "basket";
    public AboutController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> Urun([FromRoute] int id)
    {
        List<BasketItemVM>? basketItemVMList;
        if (Request.Cookies[COOKIES_BASKET] != null)
            basketItemVMList = JsonConvert.DeserializeObject<List<BasketItemVM>>(Request.Cookies[COOKIES_BASKET]);
        else
            basketItemVMList = new List<BasketItemVM> { };
        BasketItemVM? basketItemVM = basketItemVMList?.Where(b => b.ProductId == id).FirstOrDefault();
        ViewBag.BasketItemCount = basketItemVM?.Count;
        Product? product = await _context.Products
                                              .Where(p => p.Id == id)
                                              .Include(p => p.Category)
                                              .Include(p => p.ProductImage)
                                              .FirstOrDefaultAsync();


        if (product == null) return RedirectToAction(nameof(Index));
        return View(product);
    }


}


