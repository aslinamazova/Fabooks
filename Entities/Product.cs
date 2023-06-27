using System.ComponentModel.DataAnnotations;
using Entities.Common;

namespace Entities;

public class Product : BaseAuditibleEntity
{
    [Required, MaxLength(100)]
    public string Name { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required, MaxLength(255)]
    public string Description { get; set; }

    public int Stock { get; set; }

    public bool IsDeleted { get; set; } = default;
    public bool IsActive { get; set; }
    [Required]
    public int CategoryId { get; set; }

    public Category Category { get; set; }

    public ICollection<Image>? Images { get; set; }

    public string UserId { get; set; }
}

