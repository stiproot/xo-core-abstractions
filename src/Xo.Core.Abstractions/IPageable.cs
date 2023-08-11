namespace Xo.Core.Abstractions;

public interface IPageable
{
    uint TotalRowCount { get; set; }
    uint TotalPageCount { get; set; }
    uint PageSize { get; set; }
    uint PageNumber { get; set; }
}
