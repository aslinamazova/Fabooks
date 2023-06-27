using System;
using System.ComponentModel.DataAnnotations;
using Entities.Common;

namespace Entities
{
	public class Image:BaseAuditibleEntity
	{
        [Required]
        public string ImagePath { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public int ProductId { get; set; }
        
        public Product Product { get; set; }
    }
}

