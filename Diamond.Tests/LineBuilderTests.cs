using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Diamond.Tests {
    [TestClass]
    public class LineBuilderTests {
        [TestMethod]
        public void GetIntermediarySpacesInvalid() {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => LineBuilder.GetIntermediarySpacesForLine(0));
        }

        [TestMethod]
        public void GetIntermediarySpacesForDistance1() {
            Assert.AreEqual(" ", LineBuilder.GetIntermediarySpacesForLine(1));
        }

        [TestMethod]
        public void GetIntermediarySpacesForDistance2()
        {
            Assert.AreEqual("   ", LineBuilder.GetIntermediarySpacesForLine(2));
        }

        [TestMethod]
        public void GetSpacesAbove2()
        {
            Assert.AreEqual("         ", LineBuilder.GetIntermediarySpacesForLine(5));
        }
    }
}