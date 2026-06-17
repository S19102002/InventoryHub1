Activity 2
  Step 1:Fix the API Route
protected override async Task OnInitializedAsync()
{
    try
    {
        using var httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5000") // adjust port
        };

        var response = await httpClient.GetAsync("/api/productlist");
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        products = System.Text.Json.JsonSerializer.Deserialize<Product[]>(json,
            new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
Step 2: Resolve CORS Errors
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

var app = builder.Build();

app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

app.MapGet("/api/productlist", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Laptop", Price = 1200.50, Stock = 25 },
        new { Id = 2, Name = "Headphones", Price = 50.00, Stock = 100 }
    };
});

app.Run();
Step 3: Handle Malformed JSON
try
{
    var response = await httpClient.GetAsync("/api/productlist");
    response.EnsureSuccessStatusCode();

    var json = await response.Content.ReadAsStringAsync();

    products = System.Text.Json.JsonSerializer.Deserialize<Product[]>(json,
        new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
}
catch (System.Text.Json.JsonException jex)
{
    Console.WriteLine($"JSON error: {jex.Message}");
    products = Array.Empty<Product>(); // fallback to empty list
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
