using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAM.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EPAM.UnitTests
{
    [TestClass]
    public class StackTests
    {


        [TestMethod]
        public void PushTest()
        {
            Stack<int> stack = new Stack<int>(10);
            stack.Push(10);

            Assert.AreEqual(stack.Count, 1);
            Assert.AreEqual(stack.Peek(), 10);
        }

        [TestMethod]
        public void PopTest()
        {
            Stack<int> stack = new Stack<int>(10);
            stack.Push(10);

            Assert.AreEqual(stack.Pop(), 10);
            Assert.AreEqual(stack.Count, 0);
        }

        [TestMethod]
        public void PeekTest()
        {
            Stack<int> stack = new Stack<int>(10);
            stack.Push(10);
            stack.Push(11);

            Assert.AreEqual(stack.Peek(), 11);
            Assert.AreEqual(stack.Count, 2);
        }

        [TestMethod]
        public void TrimTest()
        {
            Stack<int> stack = new Stack<int>(10);
            stack.Push(10);
            stack.Push(11);
            stack.Push(111);

            Assert.AreEqual(stack.Capacity, 10);
            stack.Trim();
            Assert.AreEqual(stack.Capacity, 3);
        }
    }
}
