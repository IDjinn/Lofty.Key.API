using Lofty.Key.Domain.ValueObjects;
using Lofty.Key.Shared.Entities;

namespace Lofty.Key.Domain.Entities;

public class Door : Entity
{
    public Door(Info info)
    {
        Info = info;

        AddNotifications(info);
    }

    public Guid Id { get; } = Guid.NewGuid();
    public Info Info { get; private set; }
}