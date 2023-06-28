using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Entities.Common;

namespace Entities
{
	public class ProductImage:BaseAuditibleEntity
	{
        [Required]
        public string ImagePath { get; set; }

        [DefaultValue(false)]
        public bool PrimaryImage { get; set; }

        [DefaultValue(false)]
        public bool SecondaryImage { get; set; } 

        [Required]
        public int ProductId { get; set; }
        
        public virtual Product? Product { get; set; }
    }
}

