using System.Text.Json;

Console.WriteLine("=== Food Trailer Menu Console App ===");

using HttpClient client = new();

try
{
    string url = "http://localhost:5000/api/menu";
    string json = await client.GetStringAsync(url);

    List<MenuItem>? menuItems = JsonSerializer.Deserialize<List<MenuItem>>(
        json,
        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
    );

    if (menuItems == null || menuItems.Count == 0)
    {
        Console.WriteLine("No menu items found.");
        return;
    }

    foreach (MenuItem item in menuItems)
    {
        Console.WriteLine($"ID: {item.Id}");
        Console.WriteLine($"Name: {item.Name}");
        Console.WriteLine($"Category: {item.Category}");
        Console.WriteLine($"Price: ${item.Price:F2}");
        Console.WriteLine($"Available: {item.IsAvailable}");
        Console.WriteLine("-------------------------");
    }
}
catch (HttpRequestException ex)
{
    Console.WriteLine("Could not connect to the API.");
    Console.WriteLine(ex.Message);
}

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
}