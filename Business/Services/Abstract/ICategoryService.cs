using System;
using Entities.Dtos.Categories;

namespace Business.Services.Abstract;

public interface ICategoryService
{
    Task<IDataResult<List<CategoryGetDto>>> GetAll();
    Task<IDataResult<CategoryGetDto>> GetById(int id);
    Task<IDataResult<CategoryGetDto>> GetByName(string name);
    Task<IResult> AddAsync(CategoryCreateDto dto);
    Task<IResult> UpdateAsync(CategoryUpdateDto dto);
    Task<IResult> DeleteAsync(int id);

}

