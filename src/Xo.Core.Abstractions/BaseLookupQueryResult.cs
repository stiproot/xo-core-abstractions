namespace Xo.Core.Abstractions;

public abstract class BaseLookupQueryResult : BaseQueryResult
{
    public string Description { get; init; } = string.Empty;
}
