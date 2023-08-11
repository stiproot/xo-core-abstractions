namespace Xo.Core.Abstractions;

public interface IBaseManagerValidator<in TCommand>
    where TCommand : ICommand
{
    void Validate(TCommand cmd);
}
