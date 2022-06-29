using Lofty.Key.Shared.Commands;

namespace Lofty.Key.Shared.Handlers;

public interface IHandler<in T> where T : ICommand
{
    ValueTask<ICommandResult> Handle(T command);
}