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
    public class EnumeratorTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            int[] arr = {1, 2, 3, 4};

            Enumerator<int> enumerable = new Enumerator<int>(arr);
            Assert.AreEqual(enumerable.Length, arr.Length);
        }

        [TestMethod]
        public void MoveNextTest()
        {
            int[] arr = { 1, 2, 3, 4 };

            Enumerator<int> enumerable = new Enumerator<int>(arr);

            enumerable.MoveNext();
            Assert.AreEqual(enumerable.Current, 1);
            Assert.IsTrue(enumerable.MoveNext());
            Assert.AreEqual(enumerable.Current, 2);
            enumerable.MoveNext();
            Assert.AreEqual(enumerable.Current, 3);
            enumerable.MoveNext();
            Assert.AreEqual(enumerable.Current, 4);
            Assert.IsFalse(enumerable.MoveNext());
        }

        [TestMethod]
        public void ResetTest()
        {
            int[] arr = { 1, 2, 3, 4 };

            Enumerator<int> enumerable = new Enumerator<int>(arr);
            Assert.ThrowsException<IndexOutOfRangeException>(() => enumerable.Current);
            enumerable.MoveNext();
            enumerable.MoveNext();
            Assert.AreEqual(enumerable.Current, 2);
            enumerable.Reset();
            Assert.ThrowsException<IndexOutOfRangeException>(() => enumerable.Current);
        }
    }
}
