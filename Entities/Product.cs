using Entities.Common;

namespace Entities;

public class Product : BaseAuditibleEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public short Stock { get; set; }
    public bool IsDeleted { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}

