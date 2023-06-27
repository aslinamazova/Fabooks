using System.ComponentModel.DataAnnotations;
using Entities;

namespace Entities.Common;

public class BaseAuditibleEntity : BaseEntity
{
    [Required]
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
