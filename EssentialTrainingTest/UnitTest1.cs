using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EssentialTraining;

namespace EssentialTrainingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testInstance = new Class1();
            var testResult = testInstance.AddTwo(9, 5);
            Assert.AreEqual(14, testResult, "Expected 9 + 5 equals 14");
        }
    }
}
