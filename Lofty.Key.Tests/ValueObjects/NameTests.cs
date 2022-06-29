using Lofty.Key.Domain.ValueObjects;

namespace Lofty.Key.Tests.ValueObjects;

public class NameTests
{
    [Fact]
    public void IsValidName()
    {
        var name = new Name("Lucas", "Romero");
        Assert.Equal("Lucas", name.FirstName);
        Assert.Equal("Romero", name.LastName);
        Assert.Equal("Lucas Romero", name.ToString());
        Assert.True(name.IsValid);
    }
}