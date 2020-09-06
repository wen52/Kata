using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class SumStringsTest
    {
        [TestMethod]
        public void Testcase()
        {
            var sumStringsService = new SumStringsService();
            var result = sumStringsService.Add("123", "456");
            Assert.AreEqual("579",result);
        } 
    }
}