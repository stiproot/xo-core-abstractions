namespace Xo.Core.Abstractions;

public interface IEngine
{
    Task RunAsync(CancellationToken cancellationToken);
}

