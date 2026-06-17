Step 1: Update the Minimal API
app.MapGet("/api/productlist", () =>
{
    return new[]
    {
        new
        {
            Id = 1,
            Name = "Laptop",
            Price = 1200.50,
            Stock = 25,
            Category = new { Id = 101, Name = "Electronics" }
        },
        new
        {
            Id = 2,
            Name = "Headphones",
            Price = 50.00,
            Stock = 100,
            Category = new { Id = 102, Name = "Accessories" }
        }
    };
});
Step 2: Refine JSON Structure
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
Step 3: Validate JSON Response
[
  {
    "id": 1,
    "name": "Laptop",
    "price": 1200.5,
    "stock": 25,
    "category": {
      "id": 101,
      "name": "Electronics"
    }
  },
  {
    "id": 2,
    "name": "Headphones",
    "price": 50.0,
    "stock": 100,
    "category": {
      "id": 102,
      "name": "Accessories"
    }
  }
]
