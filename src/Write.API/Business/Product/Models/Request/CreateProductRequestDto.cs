namespace Write.API.Business.Product.Models.Request;

public record CreateProductRequestDto
{
    public string Title { get; set; }
    public Guid Code { get; set; }
    public decimal Price { get; set; }
}
