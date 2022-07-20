using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VacancyLib
{
    [TestClass]
    public class SpaceTests
    {
        [TestMethod]
        public void Test_IsRectangular_True()
        {
            Assert.IsTrue(Space.IsRectangular(3, 4, 5));
        }
        [TestMethod]
        public void Test_IsRectangular_False()
        {
            Assert.IsFalse(Space.IsRectangular(3, 4, 6));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_CirqleSpace_ArgumentOutOfRangeException()
        {
            double temp = Space.CirqleSpace(-1);
        }
        [TestMethod]
        public void Test_CirqleSpace_0()
        {
            Assert.AreEqual(0, Space.CirqleSpace(0));
        }
        [TestMethod]
        public void Test_CirqleSpace_9pi()
        {
            Assert.AreEqual(9 * Math.PI, Space.CirqleSpace(3));
        }
        [TestMethod]
        public void Test_TriangleSpace_6()
        {
            Assert.AreEqual(6, Space.TriangleSpace(3, 4, 5));
        }
        [TestMethod]
        public void Test_TriangleSpace_Sqrt5()
        {
            Assert.AreEqual(Math.Sqrt(5), Space.TriangleSpace(1, 4.5, 4.5));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_TriangleSpace_ArgumentOutOfRangeException1()
        {
            double temp = Space.TriangleSpace(-1, -2, -1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_TriangleSpace_ArgumentOutOfRangeException2()
        {
            double temp = Space.TriangleSpace(1, 2, 5);
        }
        [TestMethod]
        public void Test_FindSpace_1args()
        {
            Assert.AreEqual(9 * Math.PI, Space.FindSpace(3));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_FindSpace_2args()
        {
            double temp = Space.FindSpace(3, 4);
        }
        [TestMethod]
        public void Test_FindSpace_3args()
        {
            Assert.AreEqual(6, Space.FindSpace(3, 4, 5));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFindSpace1_ArgumentOutOfRangeException()
        {
            double temp = Space.FindSpace(-3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFindSpace3_ArgumentOutOfRangeException1()
        {
            double temp = Space.FindSpace(-3, -4, -5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFindSpace3_ArgumentOutOfRangeException2()
        {
            double temp = Space.FindSpace(30, 4, 5);
        }
    }
}