namespace Entities
{
    public class Order:BaseAuditibleEntity
	{
        public string UserId { get; set; }
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }
        public AppUser? AppUser { get; set; }
        public Product? Product { get; set; }
    }
}

