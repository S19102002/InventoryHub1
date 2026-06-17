Step 1: Consolidate Code
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public Category Category { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
}
Back‑end (Minimal API ServerApp)
  public record Category(int Id, string Name);
public record Product(int Id, string Name, double Price, int Stock, Category Category);

app.MapGet("/api/productlist", () =>
{
    return new[]
    {
        new Product(1, "Laptop", 1200.50, 25, new Category(101, "Electronics")),
        new Product(2, "Headphones", 50.00, 100, new Category(102, "Accessories"))
    };
});
Step 2: Optimize Performance
var products = new[]
{
    new Product(1, "Laptop", 1200.50, 25, new Category(101, "Electronics")),
    new Product(2, "Headphones", 50.00, 100, new Category(102, "Accessories"))
};

app.MapGet("/api/productlist", () => products);

