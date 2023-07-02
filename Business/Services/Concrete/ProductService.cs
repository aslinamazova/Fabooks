using Microsoft.AspNetCore.Http;

namespace Business.Services.Concrete;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IResult> AddAsync(ProductCreateDto dto)
    {
        if (await _productRepository.IsExistsAsync(p => p.Name == dto.Name))
        {
            throw new AlreadyIsExistsException(ExceptionMessages.ProductAlreadyExists);
        }
        await _productRepository.AddAsync(_mapper.Map<Product>(dto));
        int result = await _productRepository.SaveAsync();
        if (result == 0)
        {
            return new ErrorResult("Product does not Added");
        }
        return new SuccessResult("Product Added");
    }

    public async Task<IResult> DeleteAsync(int id)
    {
        Product product = await _productRepository.GetAsync(p => p.Id == id);
        if (product == null) throw new NotFoundException(ExceptionMessages.ProductNotFound);
        _productRepository.Delete(product);
        int result = await _productRepository.SaveAsync();
        if (result == 0)
        {
            return new ErrorResult("Product does not deleted");
        }
        return new SuccessResult("Product deleted");
    }

    public async Task<IDataResult<List<ProductGetDto>>> GetAll()
    {
        var result = await _productRepository.GetAllAsync();
        if (result.Count == 0)
        {
            return new ErrorDataResult<List<ProductGetDto>>("Products not found");
        }

        return new SuccessDataResult<List<ProductGetDto>>(_mapper.Map<List<ProductGetDto>>(result), "Products listed");
    }

    public async Task<IDataResult<ProductGetDto>> GetById(int id)
    {
        Product product = await _productRepository.GetAsync(p => p.Id == id);
        if (product == null) return new ErrorDataResult<ProductGetDto>(ExceptionMessages.ProductNotFound);
        return new SuccessDataResult<ProductGetDto>(_mapper.Map<ProductGetDto>(product));
    }

    public async Task<IDataResult<ProductGetDto>> GetByName(string name)
    {
        Product product = await _productRepository.GetAsync(p => p.Name == name);
        if (product == null) return new ErrorDataResult<ProductGetDto>(ExceptionMessages.ProductNotFound);
        return new SuccessDataResult<ProductGetDto>(_mapper.Map<ProductGetDto>(product));
    }

    public async Task<IResult> UpdateAsync(ProductUpdateDto dto)
    {
        if (!await _productRepository.IsExistsAsync(p => p.Id == dto.Id)) throw new NotFoundException(ExceptionMessages.ProductNotFound);
        _productRepository.Update(_mapper.Map<Product>(dto));
        int result = await _productRepository.SaveAsync();
        if (result == 0)
        {
            return new ErrorResult("Product does not updated");
        }
        return new SuccessResult("Product Updated");
    }

    
    
}
