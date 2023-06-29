namespace Business.Utilities.Profiles;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<ProductCreateDto, Product>();
        CreateMap<Product, ProductGetDto>();
        CreateMap<ProductUpdateDto, Product>();
    }
}
