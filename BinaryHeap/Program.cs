using System;

namespace BinaryHeap
{
    class Program
    {
        static void Main()
        {
            var heap = new Heap<int>();
            heap.Add(20);
            heap.Add(11);
            heap.Add(17);
            heap.Add(7);
            heap.Add(4);
            heap.Add(13);
            heap.Add(15);
            heap.Add(14);

            foreach (int item in heap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new String('-', 100));
        }
    }
}