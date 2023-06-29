namespace Entities.Dtos.Products;

public class ProductGetDto:BaseAuditibleEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int Stock { get; set; }
    public bool IsDeleted { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public decimal? DiscountPercent { get; set; }
    public decimal? DiscountedPrice { get; set; }
}

