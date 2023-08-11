namespace Xo.Core.Abstractions;

public interface IQueryManager<TQuery, TQueryResult>
    where TQuery : IQuery
    where TQueryResult : IQueryResult
{
    void Validate(CancellationToken cancellationToken);

    Task<TQueryResult> ManageAsync(
        TQuery qry,
        CancellationToken cancellationToken
    );
}

