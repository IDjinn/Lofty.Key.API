using Lofty.Key.Domain.ValueObjects;
using Lofty.Key.Shared.Entities;

namespace Lofty.Key.Domain.Entities;

public class Device : Entity
{
    public Device(Info info)
    {
        Info = info;
        _doors = new List<Door>();

        AddNotifications(info);
    }

    private IList<Door> _doors { get; }

    public Guid Id { get; } = Guid.NewGuid();
    public Info Info { get; private set; }

    public IReadOnlyCollection<Door> Doors
    {
        get => _doors.AsReadOnly();
    }

    public void AddDoor(Door door)
    {
        _doors.Add(door);
    }
}