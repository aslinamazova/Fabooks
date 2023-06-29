namespace Entities
{
    public class CartItem : BaseAuditibleEntity
    {
        public int Count { get; set; }

        public decimal Price { get; set; }

        public decimal Total { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public int CartId { get; set; }

        public Cart Cart { get; set; } = null!;
    }
}

