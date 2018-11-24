using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Diamond.Tests {
    [TestClass]
    public class DiamondTests {
        //[TestMethod]
        //public void GivenAReturnA() {
        //    var returnValue = Diamond.Process('A');
        //    Assert.AreEqual("A", returnValue);
        //}

        [TestMethod]
        public void GivenInvalidValueThrowsException() {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                Diamond.Process('a'));
        }

        [TestMethod]
        public void GivenBReturnABBA() {
            var returnValue = Diamond.Process('B');
            Assert.AreEqual(
                " A\n" +
                "B B\n" +
                " A", returnValue);
        }

        [TestMethod]
        public void GivenCReturnABCCBA() {
            var returnValue = Diamond.Process('C');
            Assert.AreEqual(
                "  A\n" +
                " B B\n" +
                "C   C\n" +
                " B B\n" +
                "  A", returnValue);
        }

        [TestMethod]
        public void GivenDReturnABCDDCBA() {
            var returnValue = Diamond.Process('D');
            Assert.AreEqual(
                "   A\n" +
                "  B B\n" +
                " C   C\n" +
                "D     D\n" +
                " C   C\n" +
                "  B B\n" +
                "   A", returnValue);
        }
    }
}
