using System;

namespace CrackCore
{
    public class LinkedList : ILinkedList
    {
        private Node _head;
        private Node _tail;
        public int? First => _head != null ? _head.Item : (int?)null;
        public int? Last => _tail != null ? _tail.Item : (int?)null;
        public int Count { get; private set; } // defaults to 0
        public LinkedList()
        {
        }
        public void Append(int item)
        {
            var newNode = new Node() { Item = item };

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                var currentNode = _head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
            Count++;
            _tail = newNode;
        }
        public int Get(int item)
        {
            throw new NotImplementedException();
        }
        public int FindFirst(int item)
        {
            throw new NotImplementedException();
        }
        public void Prepend(int item)
        {
            var newNode = new Node() { Item = item };
            var originalHead = _head;
            _head = newNode;
            switch (Count)
            {
                case 0:
                    _tail = newNode;
                    break;
                case 1:
                    newNode.Next = originalHead;
                    _tail = originalHead;
                    break;
                default: // more than one item in the list		
                    newNode.Next = originalHead;
                    break;
            }
            Count++;
        }
        private class Node
        {
            public Node Next { get; set; }
            public int Item { get; set; }
        }
    }
}