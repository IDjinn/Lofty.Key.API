namespace Lofty.Key.Shared.Handlers;

public interface ICommandResult
{
    public bool Success { get; }
    public string Message { get; }
}