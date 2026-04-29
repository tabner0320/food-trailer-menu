using Xunit;

public class MenuTests
{
    [Fact]
    public void Price_Should_Be_Positive()
    {
        var item = new MenuItem
        {
            Id = 1,
            Name = "Burger",
            Category = "Main",
            Price = 8.99m,
            IsAvailable = true
        };

        Assert.True(item.Price > 0);
    }

    [Fact]
    public void Name_Should_Not_Be_Empty()
    {
        var item = new MenuItem
        {
            Name = "Fries"
        };

        Assert.False(string.IsNullOrEmpty(item.Name));
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