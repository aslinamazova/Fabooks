namespace Entities;

public class Cart : BaseAuditibleEntity
{
    public decimal Subtotal { get; set; }

    public ICollection<CartItem> Cartitems { get; set; }

    public string? UserId { get; set; }

    public AppUser User { get; set; }
}

