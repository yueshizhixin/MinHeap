using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MinHeap
{

    public class MinHeap<T> 
    {
        public int Count { get; set; }
        public T[] Heap { get; set; }
        private readonly int defaultSize = 10;
        private Comparer<T> Comparer;

        public MinHeap(Comparison<T> comparison)
        {
            Heap = new T[defaultSize];
            Comparer = Comparer<T>.Create(comparison);
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

            Heap[Count] = item;
            Count++;
            int parentIndex = 0;
            
            for (int index = Count; index > 1; index = parentIndex)
            {
                parentIndex = index / 2;
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

        public T Peek()
        {
            return Heap[0];
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