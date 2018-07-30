using System.Collections.Generic;
namespace CrackCore
{
    public interface IStack<T>
    {
        void Push(T value);
        T Pop();
        T Peek();
        int Count { get; }
    }
}