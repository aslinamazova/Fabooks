namespace Entities.Dtos.Products;

public class ProductUpdateDto:BaseAuditibleEntity
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public bool IsDeleted { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public decimal? DiscountPercent { get; set; }
    public decimal? DiscountedPrice { get; set; }
}

