using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace FoodTrailerMenu.Tests;

public class MenuApiTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public MenuApiTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetAllMenuItems_ReturnsOk()
    {
        HttpResponseMessage response =
            await _client.GetAsync("/api/menu");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        List<MenuItem>? items =
            await response.Content.ReadFromJsonAsync<List<MenuItem>>();

        Assert.NotNull(items);
        Assert.NotEmpty(items);
    }

    [Fact]
    public async Task GetMenuItem_WithValidId_ReturnsItem()
    {
        HttpResponseMessage response =
            await _client.GetAsync("/api/menu/1");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        MenuItem? item =
            await response.Content.ReadFromJsonAsync<MenuItem>();

        Assert.NotNull(item);
        Assert.Equal(1, item.Id);
        Assert.Equal("Burger", item.Name);
    }

    [Fact]
    public async Task GetMenuItem_WithInvalidId_ReturnsNotFound()
    {
        HttpResponseMessage response =
            await _client.GetAsync("/api/menu/999");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task AddMenuItem_ReturnsCreated()
    {
        MenuItem newItem = new()
        {
            Id = 50,
            Name = "Fish Tacos",
            Category = "Main",
            Price = 9.99m,
            IsAvailable = true
        };

        HttpResponseMessage response =
            await _client.PostAsJsonAsync("/api/menu", newItem);

        Assert.Equal(HttpStatusCode.Created, response.StatusCode);

        MenuItem? createdItem =
            await response.Content.ReadFromJsonAsync<MenuItem>();

        Assert.NotNull(createdItem);
        Assert.Equal(50, createdItem.Id);
        Assert.Equal("Fish Tacos", createdItem.Name);
    }

    [Fact]
    public async Task UpdateMenuItem_WithValidId_ReturnsUpdatedItem()
    {
        MenuItem updatedItem = new()
        {
            Id = 1,
            Name = "Double Burger",
            Category = "Main",
            Price = 11.99m,
            IsAvailable = true
        };

        HttpResponseMessage response =
            await _client.PutAsJsonAsync("/api/menu/1", updatedItem);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        MenuItem? result =
            await response.Content.ReadFromJsonAsync<MenuItem>();

        Assert.NotNull(result);
        Assert.Equal("Double Burger", result.Name);
        Assert.Equal(11.99m, result.Price);
    }

    [Fact]
    public async Task UpdateMenuItem_WithInvalidId_ReturnsNotFound()
    {
        MenuItem updatedItem = new()
        {
            Id = 999,
            Name = "Missing Item",
            Category = "Main",
            Price = 5.99m,
            IsAvailable = true
        };

        HttpResponseMessage response =
            await _client.PutAsJsonAsync("/api/menu/999", updatedItem);

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task DeleteMenuItem_WithValidId_ReturnsNoContent()
    {
        MenuItem newItem = new()
        {
            Id = 60,
            Name = "Test Fries",
            Category = "Side",
            Price = 4.99m,
            IsAvailable = true
        };

        HttpResponseMessage createResponse =
            await _client.PostAsJsonAsync("/api/menu", newItem);

        Assert.Equal(HttpStatusCode.Created, createResponse.StatusCode);

        HttpResponseMessage deleteResponse =
            await _client.DeleteAsync("/api/menu/60");

        Assert.Equal(HttpStatusCode.NoContent, deleteResponse.StatusCode);
    }

    [Fact]
    public async Task DeleteMenuItem_WithInvalidId_ReturnsNotFound()
    {
        HttpResponseMessage response =
            await _client.DeleteAsync("/api/menu/999");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }
}