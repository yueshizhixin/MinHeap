using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinHeap;
using System.Collections;
using System.Collections.Generic;

namespace MinHeapTests
{

    [TestClass]
    public class UnitTests
    {

        [TestMethod]
        public void Enqueue()
        {

            MinHeap<int> heap = new MinHeap<int>((x, y) => x.CompareTo(y));
            heap.Enqueue(-1);
            heap.Enqueue(10);

            Assert.IsTrue(heap.Heap[0] < heap.Heap[1]);
        }

        [TestMethod]
        public void Peek()
        {
            MinHeap<int> heap = new MinHeap<int>((x, y) => x.CompareTo(y));
            heap.Enqueue(-1);
            heap.Enqueue(10);
            int min = heap.Peek();

            Assert.AreEqual(min, -1);
        }
    }
}
