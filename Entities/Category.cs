﻿namespace Entities;

public class Category : BaseAuditibleEntity
{
    [Required,MaxLength(100)]
    public string Name { get; set; }

    [Required,MaxLength(255)]
    public string Description { get; set; }

    [DefaultValue(false)]
    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public List<Product>? Products { get; set; }

    public List<ProductCategory>? ProductCategories { get; set; }

    public Category()
    {
        Products = new List<Product>();
        ProductCategories = new List<ProductCategory>();
    }

}

