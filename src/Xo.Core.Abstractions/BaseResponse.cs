namespace Xo.Core.Abstractions;

public abstract class BaseResponse
{
    public long Id { get; set; }
    public Guid Guid { get; set; }
    public long UserId { get; set; }
    public DateTime CreationTimestampUtc { get; set; }
}
