namespace Xo.Core.Abstractions;

public interface IPagedRows<TRow> : IPageable where TRow : IQueryResult
{
    IEnumerable<TRow> Rows { get; init; }
}
