using Write.API.Business.Product.Models.Request;
using Write.API.Business.Product.Models.Response;

namespace Write.API.Business.Product;

public interface IProductBusiness
{
    Task<CreateProductResponseDto> CreateProduct(CreateProductRequestDto request);
}
