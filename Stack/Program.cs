using System;

using Stack.Model;

namespace Stack
{
    class Program
    {
        static void Main()
        {
            var stack = new EasyStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var item = stack.Pop();
            var item2 = stack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);

             Stack<double> stack2 = new Stack<double>();


            var linkedStack = new LinkedStack<int>();
            linkedStack.Push(10);
            linkedStack.Push(20);
            linkedStack.Push(30);
            linkedStack.Push(40);
            linkedStack.Push(50);

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());






            var arrayStack = new ArrayStack<int>(5);
            arrayStack.Push(100);
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);
            arrayStack.Push(500);

            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());
        }
    }
}