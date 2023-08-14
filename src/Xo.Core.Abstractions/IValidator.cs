namespace Xo.Core.Abstractions;

public interface IValidator<in T>
{
    void Validate(T unvalidated);
}
