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

       
    }
}
