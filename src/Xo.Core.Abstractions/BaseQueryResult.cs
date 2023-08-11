namespace Xo.Core.Abstractions;

public abstract class BaseQueryResult
{
    public long Id { get; set; }
    public Guid Guid { get; set; }
    public long UserId { get; set; }
    public DateTime CreationTimestampUtc { get; set; }
}
