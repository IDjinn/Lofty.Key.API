using Flunt.Br;
using Lofty.Key.Shared.ValueObjects;

namespace Lofty.Key.Domain.ValueObjects;

public class Info : ValueObject
{
    public Info(string name, string? description)
    {
        Name = name;
        Description = description;

        AddNotifications(new Contract()
            .Requires()
            .IsGreaterOrEqualsThan(name, 3, nameof(name), "O nome precisa ter pelo menos 3 letras.")
            .IsLowerOrEqualsThan(name, 15, nameof(name), "O nome pode ter até 15 letras.")
            .IsLowerOrEqualsThan(description, 75, nameof(description), "A descrição pode ter até 75 letras.")
        );
    }

    public string Name { get; init; }
    public string? Description { get; init; }
}