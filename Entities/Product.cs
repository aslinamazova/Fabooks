using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Entities.Common;

namespace Entities;

public class Product : BaseAuditibleEntity
{
    [Required, MaxLength(100)]
    public string Name { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public string Description { get; set; }

    public int Stock { get; set; }

    [DefaultValue(false)]
    public bool IsDeleted { get; set; } 

    public bool IsActive { get; set; }

    [Required]
    public int CategoryId { get; set; }

    public Category? Category { get; set; }

    public decimal? Discount { get; set; }

    public string? UserId { get; set; }

    public List<ProductImage> ProductImage { get; set; }


    public Product()
    {
        ProductImage = new List<ProductImage>();
    }

}

