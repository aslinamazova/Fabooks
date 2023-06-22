namespace DataAccess.Repositories.Concrete.EFCore;

public class ProductRepository : EFBaseRepository<Product, AppDbContext>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context){}
}
