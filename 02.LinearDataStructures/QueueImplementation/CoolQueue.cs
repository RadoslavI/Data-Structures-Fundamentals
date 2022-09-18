namespace QueueImplementation
{
    class CoolQueue<T>
    {
        private ImplementLinkedList.LinkedList<T> linkedList;

        public CoolQueue()
        {
            linkedList = new ImplementLinkedList.LinkedList<T>();
        }

        public int Count { get { return linkedList.Count; } }

        public void Enqueue(T element)
        {
            linkedList.AddLast(element);
        }

        public T Peek()
        {
            return linkedList.Head.Value;
        }

        public T Dequeue()
        {
            return linkedList.RemoveHead().Value;
        }
    }
}