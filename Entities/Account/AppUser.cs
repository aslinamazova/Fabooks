namespace Entities.Account;

public class AppUser : IdentityUser
{
    public AppUser()
    {
        Orders = new List<Order>();
    }
    [Required, MaxLength(100)]
    public string FullName { get; set; }
    public bool IsActivated { get; set; }
    [Required, MaxLength(255)]
    public string Address { get; set; }
    public virtual List<Order> Orders { get; set; }

}

