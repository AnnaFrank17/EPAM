using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAM.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EPAM.UnitTests
{
    [TestClass]
    public class SetTest
    {
        [TestMethod]
        public void AddTest()
        {
            Set<int> set = new Set<int>();
            set.Add(5);
            set.Add(6);

            Assert.AreEqual(set.Length, 2);
            Assert.AreEqual(set.GetByIndex(1), 6);
        }

        [TestMethod]
        public void RemoveTest()
        {
            Set<int> set = new Set<int>();
            set.Add(5);
            set.Add(6);

            Assert.AreEqual(set.Length, 2);
            Assert.AreEqual(set.GetByIndex(0), 5);
            Assert.AreEqual(set.GetByIndex(1), 6);

            Assert.ThrowsException<IndexOutOfRangeException>(() => set.Remove(7));

            set.Remove(6);
            Assert.IsFalse(set.Contains(6));
        }

        [TestMethod]
        public void SetAlredyExistExceptionTest()
        {
            Set<int> set = new Set<int>();
            set.Add(5);
            Assert.ThrowsException<ArgumentException>(() => set.Add(5));
        }
    }
}
