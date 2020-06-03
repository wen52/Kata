using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests
{
    [TestClass()]
    public class BandNameGeneratorTests
    {
        [TestMethod()]
        public void Given_dolphin_Should_return_TheDolphin()
        {
            var bandNameGenerator = new BandNameGenerator();
            var actual = bandNameGenerator.Generate("dolphin");
            Assert.AreEqual("The Dolphin", actual);
        }

        [TestMethod()]
        public void Given_alaska_Should_return_Alaskalaska()
        {
            var bandNameGenerator = new BandNameGenerator();
            var actual = bandNameGenerator.Generate("alaska");
            Assert.AreEqual("Alaskalaska", actual);
        }
    }
}