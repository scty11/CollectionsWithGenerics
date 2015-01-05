using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CollectIt.Tests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void Can_Peek_At_Next_Item()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            //looks at the item that will be dequed next.
            Assert.AreEqual(1, queue.Peek());
        }

        [TestMethod]
        public void Can_Search_With_Contains()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            //checks whether the value is in the Queue.
            Assert.IsTrue(queue.Contains(2));
        }

        [TestMethod]
        public void Can_Convert_Queue_To_Array()
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            //creates a Array copy so can change the queue
            //without effecting the Array.
            var asArray = queue.ToArray();
            queue.Dequeue();

            Assert.AreEqual(1, asArray[0]);
            Assert.AreEqual(2, queue.Count);
        }   
    }
}
