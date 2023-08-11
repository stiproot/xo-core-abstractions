namespace Xo.Core.Abstractions;

public interface IEnricher<T>
{
    void Enrich(T obj);
}

