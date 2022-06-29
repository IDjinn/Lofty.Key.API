using Flunt.Br;
using Lofty.Key.Shared.ValueObjects;

namespace Lofty.Key.Domain.ValueObjects;

public class Email : ValueObject
{
    public Email(string mail)
    {
        Mail = mail;

        AddNotifications(new Contract()
            .Requires()
            .IsEmail(mail, nameof(mail), "Email inválido")
        );
    }

    public string Mail { get; init; }

    public static implicit operator Email(string fromString) => new(fromString);

    public override string ToString()
    {
        return Mail;
    }
}