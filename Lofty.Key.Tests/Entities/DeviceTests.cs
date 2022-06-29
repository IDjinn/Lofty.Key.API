using Lofty.Key.Domain.Entities;
using Lofty.Key.Domain.ValueObjects;

namespace Lofty.Key.Tests.Entities;

public class DeviceTests
{
    [Fact]
    public void DeviceConstructorTests()
    {
        var info = new Info("meu device", "sem desc");
        var device = new Device(info);
        Assert.NotEqual(Guid.Empty, device.Id);
        Assert.Equal(info, device.Info);

        Assert.Empty(device.Doors);
        Assert.IsAssignableFrom<IReadOnlyCollection<Door>>(device.Doors);
    }


    [Fact]
    public void AddDoorTest()
    {
        var info = new Info("meu device", "sem desc");
        var device = new Device(info);

        Assert.Empty(device.Doors);
        device.AddDoor(new Door(info));
        Assert.NotEmpty(device.Doors);
    }
}