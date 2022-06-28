using System;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            var easyMap = new EasyMap<int, string>();

            easyMap.Add(new Item<int, string>(1, "First"));
            easyMap.Add(new Item<int, string>(1, "First2"));
            easyMap.Add(new Item<int, string>(2, "Second"));
            easyMap.Add(new Item<int, string>(3, "Third"));
            easyMap.Add(new Item<int, string>(4, "Fourth"));
            easyMap.Add(new Item<int, string>(5, "Fifth"));
            easyMap.Add(new Item<int, string>(101, "One hundred first"));

            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(easyMap.Search(7) ?? "Not found");
            Console.WriteLine(easyMap.Search(3) ?? "Not found");

            easyMap.Remove(3);
            easyMap.Remove(7);

            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('-', 100));
            // --------------------------------------




            var map = new Map<int, string>();

            map.Add(new Item<int, string>(1, "First"));
            map.Add(new Item<int, string>(1, "First2"));
            map.Add(new Item<int, string>(2, "Second"));
            map.Add(new Item<int, string>(3, "Third"));
            map.Add(new Item<int, string>(4, "Fourth"));
            map.Add(new Item<int, string>(5, "Fifth"));
            map.Add(new Item<int, string>(101, "One hundred first"));

            foreach (var item in map)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(map.Search(7) ?? "Not found");
            Console.WriteLine(map.Search(3) ?? "Not found");

            map.Remove(3);
            map.Remove(7);

            foreach (var item in map)
            {
                Console.WriteLine(item);
            }
        }
    }
}