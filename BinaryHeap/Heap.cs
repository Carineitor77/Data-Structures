using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryHeap
{
    public class Heap<T> : IEnumerable
        where T : IComparable<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;

        public Heap() {}
        public Heap(List<T> items)
        {
            this.items.AddRange(items);
            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        public T Peek()
        {
            if (Count > 0)
            {
                return items[0];
            }

            return default(T);
        }

        public void Add(T item)
        {
            items.Add(item);

            int currentIndex = Count - 1;
            int parentIndex = (currentIndex - 1) / 2;

            while (currentIndex > 0 && items[parentIndex].CompareTo(items[currentIndex]) == -1)
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = (currentIndex - 1) / 2;
            }
        }

        public T GetMax()
        {
            T result = items[0];
            items[0] = items[Count - 1];
            items.RemoveAt(Count - 1);

            Sort(0);

            return result;
        }

        private void Sort(int currentIndex)
        {
            int maxIndex = currentIndex;
            int leftIndex;
            int rightIndex;

            while (currentIndex < Count)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < Count && items[leftIndex].CompareTo(items[maxIndex]) == 1)
                {
                    maxIndex = leftIndex;
                }

                if (rightIndex < Count && items[rightIndex].CompareTo(items[maxIndex]) == 1)
                {
                    maxIndex = rightIndex;
                }

                if (maxIndex == currentIndex)
                {
                    break;
                }

                Swap(currentIndex, maxIndex);
                currentIndex = maxIndex;
            }
        }

        private void Swap(int currentIndex, int parentIndex)
        {
            T temp = items[currentIndex];
            items[currentIndex] = items[parentIndex];
            items[parentIndex] = temp;
        }

        public IEnumerator GetEnumerator()
        {
            while (Count > 0)
            {
                yield return GetMax();
            }
        }
    }
}
