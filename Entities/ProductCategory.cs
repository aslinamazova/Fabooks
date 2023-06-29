namespace Entities
{
    public class ProductCategory
	{
		public int ProductId { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}

