namespace Xo.Core.Abstractions;

public abstract class BaseResponse
{
    public long Id { get; init; }
    public Guid Guid { get; init; }
    public long UserId { get; init; }
    public DateTime CreationTimestampUtc { get; init; }
}
