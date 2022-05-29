using System;

namespace HashTable
{
    class Program
    {
        static void Main()
        {
            var easyHashTable = new EasyHashTable<int>(100);
            easyHashTable.Add(5);
            easyHashTable.Add(18);
            easyHashTable.Add(777);

            Console.WriteLine(easyHashTable.Search(5));
            Console.WriteLine(easyHashTable.Search(6));


            Console.WriteLine(new String('-', 50));


            var goodHashTable = new GoodHashTable<int, string>(100);
            goodHashTable.Add(5, "hello");
            goodHashTable.Add(18, "Piece");
            goodHashTable.Add(777, "Program");

            Console.WriteLine(goodHashTable.Search(5, "hello"));
            Console.WriteLine(goodHashTable.Search(5, "Hello"));


            Console.WriteLine(new String('-', 50));


            var topHashTable = new TopHashTable<Person>(100);
            var person = new Person("Anatoly", 18, "male");
            topHashTable.Add(person);
            topHashTable.Add(new Person("Ann", 9, "female"));

            Console.WriteLine(topHashTable.Search(person));
            Console.WriteLine(topHashTable.Search(new Person("Anatoly", 23, "male")));
        }
    }
}