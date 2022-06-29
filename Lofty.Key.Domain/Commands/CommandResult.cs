using Lofty.Key.Shared.Handlers;

namespace Lofty.Key.Domain.Commands;

public class CommandResult : ICommandResult
{
    public CommandResult()
    {
    }

    public CommandResult(bool success, string message)
    {
        Success = success;
        Message = message;
    }

    public bool Success { get; }
    public string Message { get; }
}