using System.Runtime.InteropServices;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class CountDuplicateTests
    {
        [TestMethod]
        public void NoDuplicate_ShouldReturnZero()
        {
            var countDuplicateService = new CountDuplicateService();
            var result = countDuplicateService.count("abcde");
            Assert.AreEqual(0,result);
        }
        [TestMethod]
        public void aabbcde_ShouldReturnTwo()
        {
            var countDuplicateService = new CountDuplicateService();
            var result = countDuplicateService.count("aabbcde");
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void aabBcde_ShouldReturnTwo()
        {
            var countDuplicateService = new CountDuplicateService();
            var result = countDuplicateService.count("aabBcde");
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void indivisibility_ShouldReturnOne()
        {
            var countDuplicateService = new CountDuplicateService();
            var result = countDuplicateService.count("indivisibility");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Indivisibilities_ShouldReturnTwo()
        {
            var countDuplicateService = new CountDuplicateService();
            var result = countDuplicateService.count("Indivisibilities");
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void aA11_ShouldReturnTwo()
        {
            var countDuplicateService = new CountDuplicateService();
            var result = countDuplicateService.count("aA11");
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void ABBA_ShouldReturnTwo()
        {
            var countDuplicateService = new CountDuplicateService();
            var result = countDuplicateService.count("ABBA");
            Assert.AreEqual(2, result);
        }
    }
}