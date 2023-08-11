namespace Xo.Core.Abstractions;

public interface IQueryResult
{
    long Id { get; init; }
    Guid Guid { get; init; }
    long UserId { get; init; }
    DateTime CreationTimestampUtc { get; init; }
}
