using Write.API.Business.Product.Models.Request;
using Write.API.Business.Product.Models.Response;
using Write.API.Context;

namespace Write.API.Business.Product;

public class ProductBusiness : IProductBusiness
{
    #region Fields

    private readonly ProductDbContext _productDbContext;

    #endregion

    #region Ctor

    public ProductBusiness(ProductDbContext productDbContext)
    {
        _productDbContext = productDbContext;
    }

    #endregion

    #region Methods

    public async Task<CreateProductResponseDto> CreateProduct(CreateProductRequestDto request)
    {
        var entity = new Entities.Product
        {
            Code = Guid.NewGuid(),
            Title = request.Title,
            Price = request.Price,
            CreatedOnUtc = DateTime.UtcNow
        };

        await _productDbContext.Product.AddAsync(entity);
        await _productDbContext.SaveChangesAsync();

        return new CreateProductResponseDto
        {
            Id = entity.Id,
            Code = entity.Code
        };
    }

    #endregion
}
