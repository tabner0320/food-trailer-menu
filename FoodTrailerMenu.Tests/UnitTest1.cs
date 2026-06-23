
namespace FoodTrailerMenu.Tests;

public class MenuItemTests
{
    [Fact]
    public void MenuItem_ShouldStoreValues()
    {
        var item = new MenuItem
        {
            Id = 1,
            Name = "Burger",
            Category = "Entree",
            Price = 9.99m,
            IsAvailable = true
        };

        Assert.Equal(1, item.Id);
        Assert.Equal("Burger", item.Name);
        Assert.Equal("Entree", item.Category);
        Assert.Equal(9.99m, item.Price);
        Assert.True(item.IsAvailable);
    }

    [Fact]
    public void MenuItem_NameShouldNotBeEmpty()
    {
        var item = new MenuItem
        {
            Name = "Loaded Fries"
        };

        Assert.False(string.IsNullOrWhiteSpace(item.Name));
    }

    [Fact]
    public void MenuItem_CategoryShouldNotBeEmpty()
    {
        var item = new MenuItem
        {
            Category = "Side"
        };

        Assert.False(string.IsNullOrWhiteSpace(item.Category));
    }

    [Fact]
    public void MenuItem_PriceShouldBeGreaterThanZero()
    {
        var item = new MenuItem
        {
            Price = 5.50m
        };

        Assert.True(item.Price > 0);
    }

    [Fact]
    public void MenuItem_ShouldAllowAvailabilityStatus()
    {
        var item = new MenuItem
        {
            IsAvailable = false
        };

        Assert.False(item.IsAvailable);
    }
}