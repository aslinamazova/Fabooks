using Entities.Dtos.Categories;

namespace Business.Utilities.Profiles;

public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<CategoryCreateDto, Category>();
        CreateMap<Category, CategoryGetDto>();
        CreateMap<CategoryUpdateDto, Category>();
    }
}

