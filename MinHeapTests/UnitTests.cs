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

        // TODO: Refactor onece heap.data is changed to private. 
        [TestMethod]
        public void Enqueue()
        {
            MinHeap<int> heap = new MinHeap<int>();

            heap.Enqueue(10);
            heap.Enqueue(5);
            heap.Enqueue(-10);

            Assert.AreEqual(heap._data[0], -10);
        }

        [TestMethod]
        public void Dequeue()
        {
            MinHeap<int> heap = new MinHeap<int>();
            int targetItem = 1;
            int targetSize = 2;

            heap.Enqueue(10);
            heap.Enqueue(5);
            heap.Enqueue(targetItem);


            int actualItem = heap.Dequeue();
            int actualSize = heap.Count();

            Assert.AreEqual(actualItem, targetItem);
            Assert.AreEqual(actualSize, targetSize);
        }

        [TestMethod]
        public void Peek()
        {
            MinHeap<int> heap = new MinHeap<int>();
            int targetItem = -10; 

            heap.Enqueue(10);
            heap.Enqueue(5);
            heap.Enqueue(targetItem);

            int actualItem = heap.Peek();

            Assert.AreEqual(actualItem, targetItem);

        }
       
    }
}
