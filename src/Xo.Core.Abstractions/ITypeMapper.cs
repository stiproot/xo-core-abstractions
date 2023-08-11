namespace Xo.Core.Abstractions;

public interface ITypeMapper<TFrom, TTo>
{
    TTo Map(TFrom from);
}

