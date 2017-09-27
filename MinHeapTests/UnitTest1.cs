using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinHeap;
using System.Collections;
using System.Collections.Generic;

namespace MinHeapTests
{

    [TestClass]
    public class UnitTest1
    {
            

        [TestMethod]
        public void Enqueue()
        {
            // Arrange
            MinHeap<int> heap = new MinHeap<int>((x, y) => x.CompareTo(y));
            // Act
            heap.Enqueue(1);
            heap.Enqueue(10);


            // Assert
            Assert.IsTrue(heap.Heap[0] < heap.Heap[1]);
        }
    }
}
