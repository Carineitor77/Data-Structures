﻿using System;

namespace BinaryTree
{
    class Program
    {
        static void Main()
        {
            var tree = new Tree<int>();

            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);

            foreach (var item in tree.Preorder())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('-', 100));

            foreach (var item in tree.Postorder())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new String('-', 100));

            foreach (var item in tree.Inorder())
            {
                Console.WriteLine(item);
            }
        }
    }
}