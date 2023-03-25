namespace Write.API.Models.Product.Request;

public record CreateProductRequest
{
    public string Title { get; set; }
    public decimal Price { get; set; }
}
