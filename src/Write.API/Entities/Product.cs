namespace Write.API.Entities;

public class Product
{
    public int Id { get; set; }
    public Guid Code { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedOnUtc { get; set; }
}
