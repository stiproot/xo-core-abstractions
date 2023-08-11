namespace Xo.Core.Abstractions;

public abstract class QueryResultEnricher<TQueryResult> : IEnricher<TQueryResult>
  where TQueryResult : IQueryResult
{
    public abstract void Enrich(TQueryResult obj);
}
