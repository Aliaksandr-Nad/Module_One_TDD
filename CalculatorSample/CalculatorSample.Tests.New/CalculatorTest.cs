using CalculatorSample.Logic;
using NUnit.Framework;
using System;

namespace CalculatorSample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator calc = new Calculator();

        #region Add_Test
        [Test]
        public void Test_Add_Positive_Numbers()
        {
            var actual = calc.Add(7, 3);
            Assert.AreEqual(expected: 10, actual);
        }

        [Test]
        public void Test_Add_Negative_Numbers()
        {
            var actual = calc.Add(-15, -51);
            Assert.AreEqual(expected: -66, actual);
        }

        [Test]
        public void Test_Add_Zerro_Result()
        {
            var actual = calc.Add(-175, 175);
            Assert.AreEqual(expected: 0, actual);
        }
        #endregion

        #region Subtraction_Test
        [Test]
        public void Test_Subtraction_Positive_Numbers()
        {
            var actual = calc.Subtraction(453, 3);
            Assert.AreEqual(expected: 450, actual);
        }

        [Test]
        public void Test_Subtraction_Negative_Numbers()
        {
            var actual = calc.Subtraction(-115, 51);
            Assert.AreEqual(expected: -166, actual);
        }

        [Test]
        public void Test_Subtraction_Zerro_Result()
        {
            var actual = calc.Subtraction(-4, -4);
            Assert.AreEqual(expected: 0, actual);
        }
        #endregion

        #region Division_Test
        [Test]
        public void Test_Division_Positive_Numbers()
        {
            var actual = calc.Division(8, 2);
            Assert.AreEqual(expected: 4, actual);
        }

        [Test]
        public void Test_Division_Negative_Numbers()
        {
            var actual = calc.Division(-100, -50);
            Assert.AreEqual(expected: 2, actual);
        }

        [Test]
        public void Test_Division_By_Zerro()
        {
            var actual = calc.Division(-4, 0);
            Assert.AreEqual(expected: 0, actual);
        }
        #endregion

        #region Multiply_Test
        [Test]
        public void Test_Multiply_Positive_Numbers()
        {
            var actual = calc.Multiply(10, 100);
            Assert.AreEqual(expected: 1_000, actual);
        }

        [Test]
        public void Test_Multiply_Negative_Numbers()
        {
            var actual = calc.Multiply(-42, -5);
            Assert.AreEqual(expected: 210, actual);
        }

        [Test]
        public void Test_Multiply_Positive_And_Negative_Numbers()
        {
            var actual = calc.Multiply(666, -9);
            Assert.AreEqual(expected: -5994, actual);
        }

        [Test]
        public void Test_Multiply_By_Zerro()
        {
            var actual = calc.Multiply(1_000_000, 0);
            Assert.AreEqual(expected: 0, actual);
        }
        #endregion

        #region Raising_Test
        [Test]
        public void Test_Raising_Positive_Numbers()
        {
            var actual = calc.Raising(6, 6);
            Assert.AreEqual(expected: 46_656, actual);
        }

        [Test]
        public void Test_Raising_Negative_Raising()
        {
            var actual = calc.Raising(-46_656, -6);
            Assert.AreEqual(expected: 0, actual);
        }

        [Test]
        public void Test_Raising_Negativ_And_Positive_Numbers()
        {
            var actual = calc.Raising(-2, 3);
            Assert.AreEqual(expected: -8, actual);
        }
        #endregion
    }
}