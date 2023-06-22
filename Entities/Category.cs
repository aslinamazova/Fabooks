using Entities.Common;

namespace Entities;

public class Category : BaseAuditibleEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsDeleted { get; set; }
    public List<Product>? Products { get; set; }
}

