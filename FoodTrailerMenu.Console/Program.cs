using System.Net.Http.Json;

Console.WriteLine("================================");
Console.WriteLine("   Food Trailer Menu Manager");
Console.WriteLine("================================");

using HttpClient client = new()
{
    BaseAddress = new Uri("http://localhost:5000")
};

bool isRunning = true;

while (isRunning)
{
    DisplayMenu();

    Console.Write("Choose an option: ");
    string? choice = Console.ReadLine();

    Console.WriteLine();

    try
    {
        switch (choice)
        {
            case "1":
                await ViewAllMenuItems();
                break;

            case "2":
                await ViewMenuItemById();
                break;

            case "3":
                await AddMenuItem();
                break;

            case "4":
                await UpdateMenuItem();
                break;

            case "5":
                await DeleteMenuItem();
                break;

            case "6":
                isRunning = false;
                Console.WriteLine("Closing the application.");
                break;

            default:
                Console.WriteLine("Invalid option. Enter a number from 1 through 6.");
                break;
        }
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine("Could not connect to the API.");
        Console.WriteLine("Make sure the API is running on http://localhost:5000.");
        Console.WriteLine($"Error: {ex.Message}");
    }

    if (isRunning)
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to return to the main menu.");
        Console.ReadLine();
        Console.Clear();
    }
}

void DisplayMenu()
{
    Console.WriteLine();
    Console.WriteLine("1. View all menu items");
    Console.WriteLine("2. View menu item by ID");
    Console.WriteLine("3. Add a menu item");
    Console.WriteLine("4. Update a menu item");
    Console.WriteLine("5. Delete a menu item");
    Console.WriteLine("6. Exit");
    Console.WriteLine();
}

async Task ViewAllMenuItems()
{
    List<MenuItem>? menuItems =
        await client.GetFromJsonAsync<List<MenuItem>>("/api/menu");

    if (menuItems == null || menuItems.Count == 0)
    {
        Console.WriteLine("No menu items were found.");
        return;
    }

    Console.WriteLine("Menu Items");
    Console.WriteLine("------------------------------");

    foreach (MenuItem item in menuItems)
    {
        DisplayMenuItem(item);
    }
}

async Task ViewMenuItemById()
{
    int? id = ReadInteger("Enter the menu item ID: ");

    if (id == null)
    {
        return;
    }

    HttpResponseMessage response =
        await client.GetAsync($"/api/menu/{id}");

    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
    {
        Console.WriteLine($"Menu item {id} was not found.");
        return;
    }

    if (!response.IsSuccessStatusCode)
    {
        Console.WriteLine(
            $"Request failed with status code {(int)response.StatusCode}."
        );

        return;
    }

    MenuItem? item = await response.Content.ReadFromJsonAsync<MenuItem>();

    if (item == null)
    {
        Console.WriteLine("The API returned an empty response.");
        return;
    }

    DisplayMenuItem(item);
}

async Task AddMenuItem()
{
    Console.WriteLine("Add a New Menu Item");
    Console.WriteLine("------------------------------");

    int? id = ReadInteger("ID: ");

    if (id == null)
    {
        return;
    }

    string name = ReadRequiredText("Name: ");
    string category = ReadRequiredText("Category: ");

    decimal? price = ReadDecimal("Price: ");

    if (price == null)
    {
        return;
    }

    bool? isAvailable = ReadBoolean("Is this item available? (y/n): ");

    if (isAvailable == null)
    {
        return;
    }

    MenuItem newItem = new()
    {
        Id = id.Value,
        Name = name,
        Category = category,
        Price = price.Value,
        IsAvailable = isAvailable.Value
    };

    HttpResponseMessage response =
        await client.PostAsJsonAsync("/api/menu", newItem);

    if (!response.IsSuccessStatusCode)
    {
        Console.WriteLine(
            $"The item could not be added. Status: {(int)response.StatusCode}"
        );

        return;
    }

    MenuItem? createdItem =
        await response.Content.ReadFromJsonAsync<MenuItem>();

    Console.WriteLine("Menu item created successfully.");

    if (createdItem != null)
    {
        DisplayMenuItem(createdItem);
    }
}

async Task UpdateMenuItem()
{
    int? id = ReadInteger("Enter the ID of the item to update: ");

    if (id == null)
    {
        return;
    }

    HttpResponseMessage existingResponse =
        await client.GetAsync($"/api/menu/{id}");

    if (existingResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
    {
        Console.WriteLine($"Menu item {id} was not found.");
        return;
    }

    if (!existingResponse.IsSuccessStatusCode)
    {
        Console.WriteLine("The menu item could not be retrieved.");
        return;
    }

    MenuItem? existingItem =
        await existingResponse.Content.ReadFromJsonAsync<MenuItem>();

    if (existingItem == null)
    {
        Console.WriteLine("The API returned an empty response.");
        return;
    }

    Console.WriteLine("Enter the updated information.");

    string name = ReadRequiredText("Name: ");
    string category = ReadRequiredText("Category: ");

    decimal? price = ReadDecimal("Price: ");

    if (price == null)
    {
        return;
    }

    bool? isAvailable = ReadBoolean("Is this item available? (y/n): ");

    if (isAvailable == null)
    {
        return;
    }

    MenuItem updatedItem = new()
    {
        Id = id.Value,
        Name = name,
        Category = category,
        Price = price.Value,
        IsAvailable = isAvailable.Value
    };

    HttpResponseMessage response =
        await client.PutAsJsonAsync($"/api/menu/{id}", updatedItem);

    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
    {
        Console.WriteLine($"Menu item {id} was not found.");
        return;
    }

    if (!response.IsSuccessStatusCode)
    {
        Console.WriteLine(
            $"The update failed. Status: {(int)response.StatusCode}"
        );

        return;
    }

    MenuItem? result =
        await response.Content.ReadFromJsonAsync<MenuItem>();

    Console.WriteLine("Menu item updated successfully.");

    if (result != null)
    {
        DisplayMenuItem(result);
    }
}

async Task DeleteMenuItem()
{
    int? id = ReadInteger("Enter the ID of the item to delete: ");

    if (id == null)
    {
        return;
    }

    Console.Write($"Are you sure you want to delete item {id}? (y/n): ");
    string? confirmation = Console.ReadLine()?.Trim().ToLower();

    if (confirmation != "y" && confirmation != "yes")
    {
        Console.WriteLine("Delete operation cancelled.");
        return;
    }

    HttpResponseMessage response =
        await client.DeleteAsync($"/api/menu/{id}");

    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
    {
        Console.WriteLine($"Menu item {id} was not found.");
        return;
    }

    if (!response.IsSuccessStatusCode)
    {
        Console.WriteLine(
            $"The delete operation failed. Status: {(int)response.StatusCode}"
        );

        return;
    }

    Console.WriteLine($"Menu item {id} was deleted successfully.");
}

void DisplayMenuItem(MenuItem item)
{
    Console.WriteLine($"ID:        {item.Id}");
    Console.WriteLine($"Name:      {item.Name}");
    Console.WriteLine($"Category:  {item.Category}");
    Console.WriteLine($"Price:     ${item.Price:F2}");
    Console.WriteLine($"Available: {(item.IsAvailable ? "Yes" : "No")}");
    Console.WriteLine("------------------------------");
}

int? ReadInteger(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out int value) || value <= 0)
    {
        Console.WriteLine("Enter a valid positive whole number.");
        return null;
    }

    return value;
}

decimal? ReadDecimal(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();

    if (!decimal.TryParse(input, out decimal value) || value <= 0)
    {
        Console.WriteLine("Enter a valid price greater than zero.");
        return null;
    }

    return value;
}

bool? ReadBoolean(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine()?.Trim().ToLower();

    return input switch
    {
        "y" or "yes" => true,
        "n" or "no" => false,
        _ => ShowBooleanError()
    };
}

bool? ShowBooleanError()
{
    Console.WriteLine("Enter y for yes or n for no.");
    return null;
}

string ReadRequiredText(string message)
{
    while (true)
    {
        Console.Write(message);
        string? input = Console.ReadLine()?.Trim();

        if (!string.IsNullOrWhiteSpace(input))
        {
            return input;
        }

        Console.WriteLine("This value cannot be empty.");
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