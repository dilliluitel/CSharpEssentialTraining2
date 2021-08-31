using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EssentialTraining;

namespace EssentialTrainingTest
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauce();
            testInstance.Sauces.Add("Tobasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Khir");

            //expect to pass
            Assert.IsTrue(testInstance.IsSauceAwesome("Cholula"));

            //expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
