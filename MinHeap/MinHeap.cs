using System;
using System.Collections.Generic;

namespace MinHeap
{
    public class MinHeap<T> where T : IComparable
    {
        public List<T> _data;

        public MinHeap()
        {
            _data = new List<T>();
        }

        public void Enqueue(T item)
        {
            _data.Add(item);
            int child = _data.Count - 1;     
            
            while (child > 0)
            {
                int parent = (child - 1) / 2;                    

                if (_data[child].CompareTo(_data[parent]) >= 0) 
                    break;                                          // child item is larger than (or equal) parent so we're done

                Swap(ref _data, ref child, ref parent);
            }
        }

        public T Dequeue()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Heap Empty");

            int last = _data.Count - 1;
            T first = _data[0];
            _data[0] = _data[last];
            _data.RemoveAt(last);
            int parent = 0;

            last--;

            while (true)
            {
                int left = parent * 2 + 1;               // Left child index of parent

                if (left > last)
                    break;

                int right = left + 1;                    // Right child index

                // If there is a right child, and it is smaller then the left child....
                if (right <= last && _data[right].CompareTo(_data[left]) < 0)
                    left = right;

                // If parent is <= to samllest child; done.
                if (_data[parent].CompareTo(_data[left]) <= 0)
                    break;

                Swap(ref _data, ref parent, ref left);
            }

            return first;
        }

        public T Peek()
        {
            if (_data.Count == 0)
                throw new InvalidOperationException("Heap Empty");

            return _data[0];
        }

        public void Clear()
        {
            _data.Clear();
        }

        public T[] ToArray()
        {
            return _data.ToArray();
        }

        public List<T> ToList()
        {
            return _data;
        }

        public int Count()
        {
            return _data.Count;
        }

        private void Swap(ref List<T> data, ref int x, ref int y)
        {
            T temp = data[x];
            data[x] = data[y];
            data[y] = temp;
            x = y;
        }


    }
}