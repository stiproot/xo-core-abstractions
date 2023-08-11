namespace Xo.Core.Abstractions;

public abstract class BaseCommand
{
    public ICommandResult Result { get; init; } = new EmptyCommandResult();
}
