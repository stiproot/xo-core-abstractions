namespace Xo.Core.Abstractions;

public abstract class BaseUpdateCommand : BaseCommand
{
    public long Id { get; set; }
}
