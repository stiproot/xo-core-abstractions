namespace Xo.Core.Abstractions;

public interface ICommandManager<TCommand>
  where TCommand : ICommand
{
    void Validate(CancellationToken cancellationToken);

    Task ManageAsync(
      TCommand cmd,
      CancellationToken cancellationToken
    );
}
