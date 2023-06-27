using System.ComponentModel.DataAnnotations;

namespace Entities.Common;

public class BaseEntity
{
    [Required]
    public int Id { get; set; }
}

