using System;

namespace Set
{
    class Program
    {
        static void Main()
        {
            EasySet<int> easySet1 = new EasySet<int>(new int[] { 1, 2, 3, 4, 5 });
            EasySet<int> easySet2 = new EasySet<int>(new int[] { 4, 5, 6, 7, 8 });
            EasySet<int> easySet3 = new EasySet<int>(new int[] { 3, 4, 5 });

            Console.WriteLine("Union: ");
            foreach (var item in easySet1.Union(easySet2))
                Console.Write($"{item} ");

            Console.WriteLine("\nIntersection: ");
            foreach (var item in easySet1.Intersection(easySet2))
                Console.Write($"{item} ");

            Console.WriteLine("\nDifference A\\B: ");
            foreach (var item in easySet1.Difference(easySet2))
                Console.Write($"{item} ");

            Console.WriteLine("\nDifference B\\A: ");
            foreach (var item in easySet2.Difference(easySet1))
                Console.Write($"{item} ");

            Console.WriteLine("\nA Subset C: ");
            Console.Write(easySet1.Subset(easySet3));

            Console.WriteLine("\nC Subset A: ");
            Console.Write(easySet1.Subset(easySet3));

            Console.WriteLine("\nC Subset B: ");
            Console.Write(easySet2.Subset(easySet3));

            Console.WriteLine("\nSymmetric Difference: ");
            foreach (var item in easySet1.SymetricDifference(easySet2))
                Console.Write($"{item} ");
        }
    }
}