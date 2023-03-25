using Microsoft.AspNetCore.Mvc;
using Write.API.Business.Product;
using Write.API.Business.Product.Models.Request;
using Write.API.Models.Product.Request;
using Write.API.Models.Product.Response;

namespace PostgreDebeziumExample.API.Controllers;

[ApiController]
[Route("api/v1/products")]
public class ProductController : ControllerBase
{
    #region Fields
    
    private readonly IProductBusiness _productBusiness;

    #endregion

    #region Ctor
    
    public ProductController(IProductBusiness productBusiness)
    {
        _productBusiness = productBusiness;
    }

    #endregion

    #region Methods

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateProductRequest request)
    {
        var response = await _productBusiness.CreateProduct(new CreateProductRequestDto
        {
            Title = request.Title,
            Price = request.Price
        });

        return Ok(new CreateProductResponse
        {
            Id = response.Id,
            Code = response.Code
        });
    } 

    #endregion
}