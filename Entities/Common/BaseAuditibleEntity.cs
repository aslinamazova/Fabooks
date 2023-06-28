using System.ComponentModel.DataAnnotations;
using Entities;

namespace Entities.Common;

public class BaseAuditibleEntity : BaseEntity
{
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; }
}
