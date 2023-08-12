namespace Xo.Core.Abstractions;

public interface ITypeMapper<in TFrom, out TTo>
{
    TTo Map(TFrom from);
}

