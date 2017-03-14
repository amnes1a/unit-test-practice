using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_test_practice;

namespace Unit_Test_Hash
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Int64 result = 680131659347;
            String text = "leepadg";

            Assert.AreEqual(result, Program.Hash(text));
        }
    }
}
