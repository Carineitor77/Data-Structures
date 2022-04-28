using System;

namespace LinkedList.Model
{
    class Program
    {
        static void Main()
        {
            // LinkedList

            var list = new LinkedList<int>();

            list.Add(1);
            list.Add(5);
            list.Add(17);
            list.Add(42);
            list.Add(-69);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            list.Delete(17);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();




            // DuplexLinkedList

            var duplexList = new DuplexLinkedList<int>();
            duplexList.Add(1);
            duplexList.Add(2);
            duplexList.Add(3);
            duplexList.Add(4);
            duplexList.Add(5);

            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            duplexList.Delete(3);

            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var reverse = duplexList.Reverse();

            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }






            // CircularLinkedList

            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);

            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }

            circularList.Delete(3);
            Console.WriteLine();

            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
        }
    }
}