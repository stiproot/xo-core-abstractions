namespace Xo.Core.Abstractions;

public interface IQueryResult
{
    long Id { get; set; }
    Guid Guid { get; set; }
    long UserId { get; set; }
    DateTime CreationTimestampUtc { get; set; }
}
