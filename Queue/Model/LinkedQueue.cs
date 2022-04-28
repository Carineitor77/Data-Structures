using System;


namespace Queue.Model
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item<T> Next { get; set; }
        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
    public class LinkedQueue<T>
    {
        private Item<T> head;
        private Item<T> tail;

        public int Count { get; private set; }

        public LinkedQueue() { }

        public LinkedQueue(T data)
        {
            SetHeadItem(data);
        }

        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new Item<T>(data)
            {
                Next = tail
            };
            tail = item;
            Count++;
        }

        public T Dequeue()
        {
            var data = head.Data;

            var current = tail.Next;
            var previous = tail;
            while (current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            head = previous;
            head.Next = null;
            Count--;
            return data;
        }

        public T Peek()
        {
            return head.Data;
        }

        private void SetHeadItem(T data)
        {
            var item = new Item<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }
    }
}
