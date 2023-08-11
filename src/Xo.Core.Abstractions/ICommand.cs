namespace Xo.Core.Abstractions;

public interface ICommand
{
    ICommandResult Result { get; set; }
}
