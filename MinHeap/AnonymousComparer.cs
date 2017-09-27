using System;
using System.Collections.Generic;

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
}