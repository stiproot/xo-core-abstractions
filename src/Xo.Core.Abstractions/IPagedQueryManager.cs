namespace Xo.Core.Abstractions;

public interface IPagedQueryManager<TQuery, TQueryResult>
  where TQuery : IQuery
  where TQueryResult : IQueryResult
{
    void Validate(CancellationToken cancellationToken);

    Task<IEnumerable<TQueryResult>> ManageAsync(
      TQuery qry,
      CancellationToken cancellationToken
    );
}

