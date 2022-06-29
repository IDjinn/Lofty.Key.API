using Flunt.Br;
using Lofty.Key.Shared.ValueObjects;

namespace Lofty.Key.Domain.ValueObjects;

public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        AddNotifications(new Contract()
            .Requires()
            .IsGreaterOrEqualsThan(firstName, 3, nameof(firstName), "O nome deve ter pelo menos 3 letras.")
            .IsLowerOrEqualsThan(lastName, 20, nameof(firstName), "O nome deve ter até 20 letras.")
            .IsGreaterOrEqualsThan(firstName, 3, nameof(lastName), "O sobrenome deve ter pelo menos 3 letras.")
            .IsLowerOrEqualsThan(lastName, 20, nameof(lastName), "O sobrenome deve ter até 20 letras.")
        );
    }

    public string FirstName { get; init; }
    public string LastName { get; init; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}