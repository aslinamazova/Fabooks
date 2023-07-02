using System;
namespace Entities.Dtos.Categories
{
	public class CategoryUpdateDto:BaseAuditibleEntity
	{
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(255)]
        public string Description { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();


    }
}

