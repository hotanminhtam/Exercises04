﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises04;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);
        }

        public void TestIsEven()
        {
            bool result = Program.IsEven(4);
            Assert.AreEqual(true, result);

            bool result1 = Program.IsEven(3);
            Assert.AreEqual(false, result1);
        }
    }
}
