using System.Net.Http.Json;

string apiUrl = "http://localhost:5227/api/menuitems";

HttpClient client = new HttpClient();

Console.WriteLine("Food Trailer Menu Items");
Console.WriteLine("-----------------------");

var items = await client.GetFromJsonAsync<List<MenuItem>>(apiUrl);

if (items is not null)
{
    foreach (var item in items)
    {
        Console.WriteLine($"{item.Id}. {item.Name} - {item.Category} - ${item.Price} - Available: {item.IsAvailable}");
    }
}

public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
}