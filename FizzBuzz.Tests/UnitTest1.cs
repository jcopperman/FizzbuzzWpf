using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstTestMethod()
        {
            var expected = "hello";
            var actual = "hello";

            Assert.AreEqual(expected, actual);
        }
    }
}
