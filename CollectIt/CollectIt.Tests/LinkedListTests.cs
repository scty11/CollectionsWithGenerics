using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CollectIt.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void Can_Add_After()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");
            //adds it to after the first item.
            list.AddAfter(list.First, "there");

            Assert.AreEqual("there", list.First.Next.Value);
        }

        [TestMethod]
        public void Can_Remove_Last()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");
            //removes the last item.
            list.RemoveLast();            
            
            Assert.AreEqual(list.First, list.Last);
        }

        [TestMethod]
        public void Can_Find_Items()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");

            Assert.IsTrue(list.Contains("Hello"));
        }
    }
}
