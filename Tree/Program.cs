using System;

namespace Tree
{
    class Program
    {
        static void Main()
        {
            var trie = new Trie<int>();
            trie.Add("привет", 50);
            trie.Add("мир", 100);
            trie.Add("приз", 200);
            trie.Add("мирный", 50);
            trie.Add("подарок", 100);
            trie.Add("проект", 200);
            trie.Add("прапорщик", 100);
            trie.Add("правый", 200);
            trie.Add("год", 50);
            trie.Add("герой", 100);
            trie.Add("красота", 300);
            trie.Add("голубь", 200);
            trie.Add("прокрастинация", 1000);

            trie.Remove("правый");
            trie.Remove("мир");

            Search(trie, "привет");
            Search(trie, "мир");
            Search(trie, "облако");
            Search(trie, "мирный");
            Search(trie, "прокрастинация");
            Search(trie, "год");

        }

        private static void Search(Trie<int> trie, string word)
        {
            if (trie.TrySearch(word, out int value))
            {
                Console.WriteLine(word + " " + value);
            }
            else
            {
                Console.WriteLine("Not Found " + word);
            }
        }
    }
}