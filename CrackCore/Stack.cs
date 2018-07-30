using System;

namespace CrackCore
{
    public class Stack<T> : IStack<T>
    {
        private Node<T> _top;

        public int Count { get; private set; }

        public T Peek()
        {
            if(_top == null){
                throw new ArgumentException("Stack is Empty");
            }

            return _top.Value;
        }

        public T Pop()
        {
            if(_top == null){
                throw new ArgumentException("Stack is Empty");
            }
            var value = _top.Value;
            _top = _top.Next;
            Count--;

            return value;
        }

        public void Push(T value)
        {
            var newTop = new Node<T>(value);
            newTop.Next = _top;
            _top = newTop;
            Count++;
        }

        private class Node<TNode> where TNode : T
        {
            public Node<TNode> Next { get; set; }
            public TNode Value { get; private set; }
        
            public Node(TNode value)
            {
                Value = value;
            }
        }

    }
}