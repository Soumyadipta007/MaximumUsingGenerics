using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaxUsingGenerics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindingMaxNumberAtPosition1()
        {
            int maxNumber = MaxNumberCheck.MaximumIntegerNumber(30, 20, 10);
            Assert.AreEqual(30, maxNumber);
        }
        [TestMethod]
        public void FindingMaxNumberAtPosition2()
        {
            int maxNumber = MaxNumberCheck.MaximumIntegerNumber(20, 30, 10);
            Assert.AreEqual(30, maxNumber);
        }
        [TestMethod]
        public void FindingMaxNumberAtPosition3()
        {
            int maxNumber = MaxNumberCheck.MaximumIntegerNumber(10, 20, 30);
            Assert.AreEqual(30, maxNumber);
        }
    }
}
