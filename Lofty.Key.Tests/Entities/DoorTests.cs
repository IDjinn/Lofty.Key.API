using Lofty.Key.Domain.Entities;
using Lofty.Key.Domain.ValueObjects;

namespace Lofty.Key.Tests.Entities;

public class DoorTests
{
    [Fact]
    public void ConstructorTests()
    {
        var info = new Info("doorname", null);
        var door = new Door(info);

        Assert.NotEqual(Guid.Empty, door.Id);
        Assert.Equal(info, door.Info);
        Assert.True(door.IsValid);
    }
}