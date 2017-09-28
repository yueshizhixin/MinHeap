using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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

            int child = _data.Count - 1;                        // child index; start at end
            while (child > 0)
            {
                int parent = (child - 1) / 2;                       // parent index

                if (_data[child].CompareTo(_data[parent]) >= 0) 
                    break;                                         // child item is larger than (or equal) parent so we're done

                Swap(ref _data, ref child, ref parent);
                //T temp = _data[child];
                //_data[child] = _data[parent];
                //_data[parent] = temp;
                //child = parent;
            }
        }


        private void Swap(ref List<T> data, ref int child, ref int parent)
        {
            T temp = data[child];
            data[child] = data[parent];
            data[parent] = temp;
            child = parent;
        }


    }
}