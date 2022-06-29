using Flunt.Notifications;

namespace Lofty.Key.Shared.Entities;

public abstract class Entity : Notifiable<Notification>
{
    public Guid Id { get; protected set; }
}