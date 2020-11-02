using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Oleg.MainClass.Proc16(), 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Oleg.MainClass.Proc17(), 2);

        }
    }
}
