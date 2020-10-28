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
        [TestMethod]
        public void FindingMaxFloatNumberAtPosition1()
        {
            double maxNumber = MaxNumberCheck.MaximumFloatNumber(30.0, 20.0, 10.0);
            Assert.AreEqual(30.0, maxNumber);
        }
        [TestMethod]
        public void FindingMaxFloatNumberAtPosition2()
        {
            double maxNumber = MaxNumberCheck.MaximumFloatNumber(20.0, 30.0, 10.0);
            Assert.AreEqual(30.0, maxNumber);
        }
        [TestMethod]
        public void FindingMaxFloatNumberAtPosition3()
        {
            double maxNumber = MaxNumberCheck.MaximumFloatNumber(10.0, 20.0, 30.0);
            Assert.AreEqual(30.0, maxNumber);
        }
        [TestMethod]
        public void FindingMaxStringAtPosition1()
        {
            string maxString = MaxNumberCheck.MaximumString("Banana", "Apple","Peach");
            Assert.AreEqual("Peach", maxString);
        }
        [TestMethod]
        public void FindingMaxStringAtPosition2()
        {
            string maxString = MaxNumberCheck.MaximumString("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", maxString);
        }
        [TestMethod]
        public void FindingMaxStringAtPosition3()
        {
            string maxString = MaxNumberCheck.MaximumString("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", maxString);
        }
        [TestMethod]
        public void FindingMaxNumberUsingGenerics()
        {
            int maxNumber = MaxNumberCheck.findMax(10, 20, 30);
            Assert.AreEqual(30, maxNumber);
        }
        [TestMethod]
        public void FindingMaxFloatNumberUsingGenerics()
        {
            double maxNumber = MaxNumberCheck.findMax(10.0, 20.0, 30.0);
            Assert.AreEqual(30.0, maxNumber);
        }
        [TestMethod]
        public void FindingMaxStringUsingGenerics()
        {
            string maxString = MaxNumberCheck.findMax("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", maxString);
        }
        [TestMethod]
        public void FindingMaxNumberUsingGenericsClass()
        {
            int maxNumber = FindMaxGenericClass<int>.testMax(10, 20, 30);
            Assert.AreEqual(30, maxNumber);
        }
        [TestMethod]
        public void FindingMaxFloatNumberUsingGenericsClass()
        {
            double maxNumber = FindMaxGenericClass<double>.testMax(10.0, 20.0, 30.0);
            Assert.AreEqual(30.0, maxNumber);
        }
        [TestMethod]
        public void FindingMaxStringUsingGenericsClass()
        {
            string maxString = FindMaxGenericClass<string>.testMax("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", maxString);
        }
        [TestMethod]
        public void FindingMaxNumberUsingGenericsClassAndSorting()
        {
            int[] arr = {10, 20, 30};
            int maxNumber = FindMaxGenericClass<int>.GetMaxValue(arr);
            Assert.AreEqual(30, maxNumber);
        }
        [TestMethod]
        public void FindingMaxFloatNumberUsingGenericsClassAndSorting()
        {
            double[] arr = { 10.0, 20.0, 30.0 };
            double maxNumber = FindMaxGenericClass<double>.GetMaxValue(arr);
            Assert.AreEqual(30.0, maxNumber);
        }
        [TestMethod]
        public void FindingMaxStringUsingGenericsClassAndSorting()
        {
            string[] arr = { "Apple", "Peach", "Banana" };
            string maxString = FindMaxGenericClass<string>.GetMaxValue(arr);
            Assert.AreEqual("Peach", maxString);
        }
    }
}
