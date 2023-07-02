namespace Business;

public static class ConfigurationService
{
    public static IServiceCollection AddBusinessConfiguration(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<IProductService, ProductService>();
      
        services.AddScoped<ICategoryService, CategoryService>();
        return services;
    }
}
