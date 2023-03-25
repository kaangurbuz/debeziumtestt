namespace Write.API.Models.Product.Response;

public record CreateProductResponse
{
    public int Id { get; init; }
    public Guid Code { get; init; }
}
