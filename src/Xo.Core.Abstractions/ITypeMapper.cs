namespace Xo.Core.Abstractions;

public interface ITypeMapper<TSource, TTarget>
{
    TTarget Map(TSource source);
}
