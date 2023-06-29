using DataAccess.Repositories.Concrete.EFCore;
using Entities.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static  class ConfigurationServices
{
    public static IServiceCollection AddDataAccessConfiguration(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("Default"));
        });
        services.AddIdentity<AppUser, IdentityRole>()
          .AddDefaultTokenProviders()
          .AddEntityFrameworkStores<AppDbContext>();
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }

}
