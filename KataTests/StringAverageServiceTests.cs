using System;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class StringAverageServiceTests
    {
        private StringAverageService _stringAverageService = new StringAverageService();

        [TestMethod]
        public void TestCase1()
        {
            var actual = _stringAverageService.GetAverage("zero nine five two");

            Assert.AreEqual("four", actual);
        }
        [TestMethod]
        public void TestCase2()
        {
            var actual = _stringAverageService.GetAverage("four six two three");

            Assert.AreEqual("three", actual);
        }

        [TestMethod]
        public void TestCase3()
        {
            var actual = _stringAverageService.GetAverage("one one eight one");

            Assert.AreEqual("two", actual);
        }
        [TestMethod]
        public void TestCase4()
        {
            var actual = _stringAverageService.GetAverage("zero zero zero zero zero");

            Assert.AreEqual("zero", actual);
        }
        [TestMethod]
        public void TestCase5()
        {
            var actual = _stringAverageService.GetAverage("");

            Assert.AreEqual("n/a", actual);
        }
    }
}
