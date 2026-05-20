var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

List<MenuItem> menuItems = new()
{
    new MenuItem
    {
        Id = 1,
        Name = "Burger",
        Category = "Main",
        Price = 8.99m,
        IsAvailable = true
    },

    new MenuItem
    {
        Id = 2,
        Name = "Fries",
        Category = "Side",
        Price = 3.99m,
        IsAvailable = true
    }
};

app.MapGet("/api/menu", () =>
{
    return menuItems;
});

app.MapGet("/api/menu/{id}", (int id) =>
{
    var item = menuItems.FirstOrDefault(x => x.Id == id);

    if (item == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(item);
});

app.MapPost("/api/menu", (MenuItem item) =>
{
    menuItems.Add(item);

    return Results.Created($"/api/menu/{item.Id}", item);
});

app.MapPut("/api/menu/{id}", (int id, MenuItem updatedItem) =>
{
    var item = menuItems.FirstOrDefault(x => x.Id == id);

    if (item == null)
    {
        return Results.NotFound();
    }

    item.Name = updatedItem.Name;
    item.Category = updatedItem.Category;
    item.Price = updatedItem.Price;
    item.IsAvailable = updatedItem.IsAvailable;

    return Results.Ok(item);
});

app.MapDelete("/api/menu/{id}", (int id) =>
{
    var item = menuItems.FirstOrDefault(x => x.Id == id);

    if (item == null)
    {
        return Results.NotFound();
    }

    menuItems.Remove(item);

    return Results.Ok();
});

app.Run();

public class MenuItem
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Category { get; set; } = "";

    public decimal Price { get; set; }

    public bool IsAvailable { get; set; }
}