namespace Xo.Core.Abstractions;

public interface IController<T>
{
    bool Control(T subject);
}
