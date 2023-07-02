using System;
using Entities.Dtos.Categories;

namespace Business.Services.Concrete;


public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _CategoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository CategoryRepository, IMapper mapper)
    {
        _CategoryRepository = CategoryRepository;
        _mapper = mapper;
    }

    public async Task<IResult> AddAsync(CategoryCreateDto dto)
    {
        if (await _CategoryRepository.IsExistsAsync(p => p.Name == dto.Name))
        {
            throw new AlreadyIsExistsException(ExceptionMessages.CategoryAlreadyExists);
        }
        await _CategoryRepository.AddAsync(_mapper.Map<Category>(dto));
        int result = await _CategoryRepository.SaveAsync();
        if (result == 0)
        {
            return new ErrorResult("Category does not Added");
        }
        return new SuccessResult("Category Added");
    }

    public async Task<IResult> DeleteAsync(int id)
    {
        Category Category = await _CategoryRepository.GetAsync(p => p.Id == id);
        if (Category == null) throw new NotFoundException(ExceptionMessages.CategoryNotFound);
        _CategoryRepository.Delete(Category);
        int result = await _CategoryRepository.SaveAsync();
        if (result == 0)
        {
            return new ErrorResult("Category does not deleted");
        }
        return new SuccessResult("Category deleted");
    }

    public async Task<IDataResult<List<CategoryGetDto>>> GetAll()
    {
        var result = await _CategoryRepository.GetAllAsync();
        if (result.Count == 0)
        {
            return new ErrorDataResult<List<CategoryGetDto>>("Categorys not found");
        }

        return new SuccessDataResult<List<CategoryGetDto>>(_mapper.Map<List<CategoryGetDto>>(result), "Categorys listed");
    }

    public async Task<IDataResult<CategoryGetDto>> GetById(int id)
    {
        Category Category = await _CategoryRepository.GetAsync(p => p.Id == id);
        if (Category == null) return new ErrorDataResult<CategoryGetDto>(ExceptionMessages.CategoryNotFound);
        return new SuccessDataResult<CategoryGetDto>(_mapper.Map<CategoryGetDto>(Category));
    }

    public async Task<IDataResult<CategoryGetDto>> GetByName(string name)
    {
        Category Category = await _CategoryRepository.GetAsync(p => p.Name == name);
        if (Category == null) return new ErrorDataResult<CategoryGetDto>(ExceptionMessages.CategoryNotFound);
        return new SuccessDataResult<CategoryGetDto>(_mapper.Map<CategoryGetDto>(Category));
    }

    public async Task<IResult> UpdateAsync(CategoryUpdateDto dto)
    {
        if (!await _CategoryRepository.IsExistsAsync(p => p.Id == dto.Id)) throw new NotFoundException(ExceptionMessages.CategoryNotFound);
        _CategoryRepository.Update(_mapper.Map<Category>(dto));
        int result = await _CategoryRepository.SaveAsync();
        if (result == 0)
        {
            return new ErrorResult("Category does not updated");
        }
        return new SuccessResult("Category Updated");
    }
}

