using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MinHeap
{
    public class AnonymousComparer<T> : IComparer<T>
    {
        private Comparison<T> comparison;

        public AnonymousComparer(Comparison<T> comparison)
        {
            if (comparison == null)
                throw new ArgumentNullException("comparison");
            this.comparison = comparison;
        }

        public int Compare(T x, T y)
        {
            return comparison(x, y);
        }
    }

    public class MinHeap<T> 
    {
        public int Count { get; set; }
        public T[] Heap { get; set; }
        private readonly int defaultSize = 100;
        //private Comparer<T> Comparer;
        AnonymousComparer<T> Comparer;

        public MinHeap(Comparison<T> comparison)
        {
            Heap = new T[defaultSize];
            Comparer = new AnonymousComparer<T>(comparison);
            Count = 0;

        }

        public int Clear()
        {
            throw new NotImplementedException();
        }

        public int Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void Enqueue(T item)
        {

            if (Count + 1 > Heap.Length - 1)
                Resize();

            // Insert to end of array
            Count++;
            Heap[Count] = item;
            int index = Count;
            

            while (index > 0)
            {
                int parentIndex = index / 2;
                T parent = Heap[parentIndex];
                
                if (Comparer.Compare(item, parent) < 0)
                {
                    // Swap
                    Heap[parentIndex] = item;
                    Heap[index] = parent;
                    index = parentIndex;
                }
                else
                {
                    break;
                }

            }
            
        }

        public int Dequeue(T item)
        {
            throw new NotImplementedException();
        }

        public int Peek()
        {
            throw new NotImplementedException();
        }

        public T[] ToArray()
        {
            throw new NotImplementedException();
        }

        public override String ToString()
        {
            throw new NotImplementedException();
        }

        private bool Resize()
        {

            return true;
        }


    }
}