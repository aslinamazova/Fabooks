using System;
namespace WebMVC.ViewModels.Basket
{
	public class BasketItemVM
	{
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }
    }
}

