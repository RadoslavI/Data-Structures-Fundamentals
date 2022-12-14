using ImplementLinkedList;
using System;
using System.Text;

namespace StackImplementation
{
    class CoolStack<T>
    {
        private ImplementLinkedList.LinkedList<T> linkedList;

        public CoolStack()
        {
            linkedList = new ImplementLinkedList.LinkedList<T>();
        }

        public int Count { get { return linkedList.Count; } }

        public void Push(T element)
        {
            linkedList.Add(element);
        }

        public T Peek()
        {
            return linkedList.Head.Value;
        }

        public T Pop()
        {
            return linkedList.RemoveHead().Value;
        }
    }
}