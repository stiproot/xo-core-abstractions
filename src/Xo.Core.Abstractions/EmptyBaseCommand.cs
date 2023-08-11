namespace Xo.Core.Abstractions;

public abstract class EmptyBaseCommand
{
    public ICommandResult Result { get; set; } = new EmptyCommandResult();
}
