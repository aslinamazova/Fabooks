using System;
namespace DataAccess.Repositories.Concrete.EFCore;

public class CategoryRepository : EFBaseRepository<Category, AppDbContext>, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context) { }
}

