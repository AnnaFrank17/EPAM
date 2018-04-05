using System;
using GenericCollection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestStack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Stack<int> stack = new Stack<int>(8);
            stack.Push(45);

            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void Pop()
        {
            Stack<int> stack = new Stack<int>(8);
            stack.Push(45);

            Assert.AreEqual(45, stack.Pop());
            Assert.AreEqual(0, stack.Count);
        }
    }
}
