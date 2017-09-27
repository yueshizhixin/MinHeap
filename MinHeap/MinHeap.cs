using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MinHeap
{
    class MinHeap<T> : IEnumerable<T>, IReadOnlyCollection<T>
    {
        public int Count { get; set; }

        public int Clear()
        {
            throw new NotImplementedException();
        }

        public int Contains(T item)
        {
            throw new NotImplementedException();
        }

        public int Enqueue(T item)
        {
            throw new NotImplementedException();
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


        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}