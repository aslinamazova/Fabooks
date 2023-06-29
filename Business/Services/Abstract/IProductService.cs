namespace Business.Services.Abstract;

public interface IProductService
{
    Task<IDataResult<List<ProductGetDto>>> GetAll();
    Task<IDataResult<ProductGetDto>> GetById(int id);
    Task<IDataResult<ProductGetDto>> GetByName(string name);
    Task<IResult> AddAsync(ProductCreateDto dto);
    Task<IResult> UpdateAsync(ProductUpdateDto dto);
    Task<IResult> DeleteAsync(int id);

}
