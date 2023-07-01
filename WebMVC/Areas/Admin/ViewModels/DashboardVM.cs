using Entities;

namespace WebMVC.Areas.Admin.ViewModels;

public class DashboardVM
{
    public int? UserCount { get; set; }
    public int ProductCount { get; set; }
    public int OrderCount { get; set; }
    public List<Order> Orders { get; set; }
}
