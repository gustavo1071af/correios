using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebServicesCorreios.Console;

namespace UnitTeste
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestOne()
        {
           
            Assert.AreEqual("Rua Ministro Orozimbo Nonato", "Rua Ministro Orozimbo Nonato");
        }

        [TestMethod]
        public void TestTwo()
        {

            Assert.AreEqual("Rua Ministro Orozimbo Nonato", "Rua Ministro Orozimbo");
        }
    }
}
