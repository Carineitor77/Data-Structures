﻿using System;

namespace LinkedList.Model
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item<T> Next { get; set; }
        public Item(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}