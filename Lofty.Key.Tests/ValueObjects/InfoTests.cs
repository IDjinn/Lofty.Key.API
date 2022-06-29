using Lofty.Key.Domain.ValueObjects;

namespace Lofty.Key.Tests.ValueObjects;

public class InfoTests
{
    [Fact]
    public void IsValidInfo()
    {
        var info = new Info("algum nome", "desc");
        Assert.Equal("algum nome", info.Name);
        Assert.Equal("desc", info.Description);
        Assert.True(info.IsValid);
    }

    [Fact]
    public void CheckNullableDescriptionInfo()
    {
        var info = new Info("nome", null);
        Assert.Equal("nome", info.Name);
        Assert.Null(info.Description);
        Assert.True(info.IsValid);
    }
}