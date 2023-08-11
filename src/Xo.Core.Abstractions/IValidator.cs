namespace Xo.Core.Abstractions;

public interface IValidator<in T>
{
    bool Validate(T subject);
}
