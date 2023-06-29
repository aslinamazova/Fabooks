namespace WebMVC.ViewModels.Basket
{
    public class BasketItemDetailVM
	{
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }
        public bool IsDeleted { get; set; }

    }
}

