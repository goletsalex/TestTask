using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestTaskApp.Helpers.Tests
{
    [TestClass()]
    public class ErrorLogTests
    {
        [TestMethod()]
        public void LogStringMessage_PositiveTest()
        {
            var expected = true;

            var actual = Helpers.ErrorLog.Log("Test");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LogStringMessage_NegativeTest()
        {
            var expected = false;

            var actual = Helpers.ErrorLog.Log(" ");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LogException_PositiveTest()
        {
            var expected = true;

            var actual = Helpers.ErrorLog.Log(new Exception());

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LogException_NegativeTest()
        {
            var expected = false;

            var actual = Helpers.ErrorLog.Log((Exception)null);

            Assert.AreEqual(expected, actual);
        }
    }
}