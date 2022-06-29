using Flunt.Notifications;
using Lofty.Key.Domain.Commands;
using Lofty.Key.Domain.Entities;
using Lofty.Key.Domain.Repositories;
using Lofty.Key.Domain.ValueObjects;
using Lofty.Key.Shared.Handlers;

namespace Lofty.Key.Domain.Handlers;

public class UserHandler : Notifiable<Notification>, IHandler<RegisterUserCommand>
{
    private IUserRepository _userRepository;

    public UserHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async ValueTask<ICommandResult> Handle(RegisterUserCommand command)
    {
        command.Validate();
        if (!command.IsValid)
        {
            AddNotifications(command);
            return new CommandResult(false, "Não foi possível criar o usuário.");
        }

        if (await _userRepository.EmailAlreadyExists(command.Email))
            AddNotification("email", "Email já utilizado.");

        //Value objects
        var email = new Email(command.Email);
        var name = new Name(command.FirstName, command.LastName);

        //Entities
        var user = new User(name, email, command.Password);
        if (!user.IsValid)
        {
            AddNotifications(user);
            return new CommandResult(false, "Não foi possível criar o usuário.");
        }

        //TODO: salvar no banco

        return new CommandResult(true, "OK");
    }
}