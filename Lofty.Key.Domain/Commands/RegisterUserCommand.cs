using Flunt.Br;
using Flunt.Notifications;
using Lofty.Key.Shared.Commands;

namespace Lofty.Key.Domain.Commands;

public class RegisterUserCommand : Notifiable<Notification>, ICommand
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }


    public void Validate()
    {
        AddNotifications(new Contract()
            .Requires()
            .IsGreaterOrEqualsThan(FirstName, 3, nameof(FirstName), "O nome deve ter pelo menos 3 letras.")
            .IsLowerOrEqualsThan(LastName, 20, nameof(LastName), "O nome deve ter até 20 letras.")
            .IsGreaterOrEqualsThan(FirstName, 3, nameof(FirstName), "O sobrenome deve ter pelo menos 3 letras.")
            .IsLowerOrEqualsThan(LastName, 20, nameof(LastName), "O sobrenome deve ter até 20 letras.")
            .IsEmail(Email, nameof(Email), "Email inválido")
        );
    }
}