using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DT.CodeExam.Core.Core;
using DT.CodeExam.Core.Core.Exceptions;

namespace DT.CodeExam.UnitTest
{
    [TestClass]
    public class CoreTests
    {


        [TestMethod]
        public void TestZero()
        {
            var result = "zero";
            var number = new Number(0m);
            Assert.AreEqual(result, number.Spell());
        }

        [TestMethod]
        public void TestDecimalStartWithZero()
        {
            var result = "zero point zero one ";
            var number = new Number(0.01m);
            Assert.AreEqual(result, number.Spell());
        }

        [TestMethod]
        public void TestMinusNumber()
        {
            var result = "minus zero point zero one ";
            var number = new Number(-0.01m);
            Assert.AreEqual(result, number.Spell());
        }

        [TestMethod]
        public void TestBigNumber()
        {
            var result = "one thousand and thirty-two point zero one ";
            var number = new Number(1032.01m);
            Assert.AreEqual(result, number.Spell());
        }

        [TestMethod] 

        public void TestSeperator()
        {
            var result = "one hundred million, one hundred thousand and thirty-two point zero one ";
            var number = new Number(100100032.01m);
            Assert.AreEqual(result, number.Spell());
        }

        [TestMethod]
        public void TestTooHugeException()
        {
            try
            {
                var number = new Number((decimal) Math.Pow(10, 23));
                Assert.Fail();
            }
            catch (NumberTooHugeException e)
            {
                Assert.IsTrue(e.GetType() == typeof(NumberTooHugeException));
            }
        }
    }
}
