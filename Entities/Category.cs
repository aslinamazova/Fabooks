using System.ComponentModel.DataAnnotations;
using Entities.Common;

namespace Entities;

public class Category : BaseAuditibleEntity
{
    [Required,MaxLength(100)]
    public string Name { get; set; }

    [Required,MaxLength(255)]
    public string Description { get; set; }

    public bool IsDeleted { get; set; } = default;
    public bool IsActive { get; set; }
    public List<Product>? Products { get; set; }
}

