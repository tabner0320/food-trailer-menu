using FoodTrailerMenu.Api.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// In-memory data store
var menu = new List<MenuItem>
{
    new MenuItem { Id = 1, Name = "Burger", Category = "Main", Price = 8.99m, IsAvailable = true },
    new MenuItem { Id = 2, Name = "Fries", Category = "Side", Price = 3.49m, IsAvailable = true }
};

// GET all
app.MapGet("/api/menuitems", () => Results.Ok(menu));

// GET by id
app.MapGet("/api/menuitems/{id:int}", (int id) =>
{
    var item = menu.FirstOrDefault(x => x.Id == id);
    return item is not null ? Results.Ok(item) : Results.NotFound();
});

// POST
app.MapPost("/api/menuitems", (MenuItem newItem) =>
{
    var nextId = menu.Count == 0 ? 1 : menu.Max(x => x.Id) + 1;
    newItem.Id = nextId;
    menu.Add(newItem);
    return Results.Created($"/api/menuitems/{newItem.Id}", newItem);
});

// PUT
app.MapPut("/api/menuitems/{id:int}", (int id, MenuItem updatedItem) =>
{
    var item = menu.FirstOrDefault(x => x.Id == id);
    if (item is null) return Results.NotFound();

    item.Name = updatedItem.Name;
    item.Category = updatedItem.Category;
    item.Price = updatedItem.Price;
    item.IsAvailable = updatedItem.IsAvailable;

    return Results.Ok(item);
});

// DELETE
app.MapDelete("/api/menuitems/{id:int}", (int id) =>
{
    var item = menu.FirstOrDefault(x => x.Id == id);
    if (item is null) return Results.NotFound();

    menu.Remove(item);
    return Results.NoContent();
});

app.Run();