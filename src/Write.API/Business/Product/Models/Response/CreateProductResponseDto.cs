namespace Write.API.Business.Product.Models.Response;

public record CreateProductResponseDto
{
    public int Id { get; init; }
    public Guid Code { get; init; }
}