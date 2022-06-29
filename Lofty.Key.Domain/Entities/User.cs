using Lofty.Key.Domain.ValueObjects;
using Lofty.Key.Shared.Entities;

namespace Lofty.Key.Domain.Entities;

public class User : Entity
{
    public User(Name name, Email email, string password)
    {
        Name = name;
        Email = email;
        Password = password;

        AddNotifications(name, email);
    }

    public Guid Id { get; } = Guid.NewGuid();
    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public string Password { get; private set; }
}