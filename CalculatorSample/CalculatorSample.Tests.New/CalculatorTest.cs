using CalculatorSample.Logic;
using CalculatorSample.Logic.Logger;
using Moq;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace CalculatorSample.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        Mock<ILogger> _mock;
        Calculator _calc;
        
        [SetUp]
        public void SetUp()
        {
            _mock = new Mock<ILogger>();
            _mock.Setup(l => l.Log(It.IsAny<string>())).Callback<string>(s => Debug.WriteLine(s));
            _calc = new Calculator(_mock.Object);
        }

        [TestCase(9, 3, new int[] { 55, 9, 900 }, TestName = "Test_SearchNumbers_Positive_Numbers")]
        [TestCase(27, 3, new int[] { 1, 999, 999 }, TestName = "Test_SearchNumbers_Max_Sum")]
        [TestCase(0, 3, new int[] { 1, 0, 0 }, TestName = "Test_SearchNumbers_Zero_Sum")]
        [TestCase(0, 0, new int[] { 1, 0, 0 }, TestName = "Test_SearchNumbers_Zero_Sum_And_Range")]
        [TestCase(4, 0, new int[0], TestName = "Test_SearchNumbers_Empty_Array")]
        [TestCase(8, 0, new int[0], TestName = "Test_SearchNumbers_Zero_Range")]
        public void Test_SearchNumbers(int sum, int range, int[] z)
        {
            var actual = _calc.SearchNumbers(sum: sum, range: range);
            Assert.AreEqual(expected: z, actual);
        }

        [TestCase(-3, 3, TestName = "Test_SearchNumbers_Negative_Sum")]
        [TestCase(3, -3, TestName = "Test_SearchNumbers_Negative_Range")]
        public void Test_SearchNumbers_Negative_Pass(int sum, int range)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _calc.SearchNumbers(sum: sum, range: range));
        }

        #region Add_Test
        [TestCase(7, 3, 10, TestName = "Test_Add_Positive_Numbers")]
        [TestCase(-15, -51, -66, TestName = "Test_Add_Negative_Numbers")]
        [TestCase(-175, 175, 0, TestName = "Test_Add_Zerro_Result")]
        public void Test_Param(int a, int b, int z)
        {
            var actual = _calc.Add(a, b);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: z, actual);
        }
        #endregion

        #region Subtraction_Test
        [Test]
        public void Test_Subtraction_Positive_Numbers()
        {
            var actual = _calc.Subtraction(453, 3);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: 450, actual);
        }

        [Test]
        public void Test_Subtraction_Negative_Numbers()
        {
            var actual = _calc.Subtraction(-115, 51);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: -166, actual);
        }

        [Test]
        public void Test_Subtraction_Zerro_Result()
        {
            var actual = _calc.Subtraction(-4, -4);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: 0, actual);
        }
        #endregion

        #region Division_Test
        [Test]
        public void Test_Division_Positive_Numbers()
        {
            var actual = _calc.Division(8, 2);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: 4, actual);
        }

        [Test]
        public void Test_Division_Negative_Numbers()
        {
            var actual = _calc.Division(-100, -50);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: 2, actual);
        }

        [Test]
        public void Test_Division_By_Zerro()
        {
            var actual = _calc.Division(-4, 0);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: 0, actual);
        }
        #endregion

        #region Multiply_Test
        [Test]
        public void Test_Multiply_Positive_Numbers()
        {
            var actual = _calc.Multiply(10, 100);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: 1_000, actual);
        }

        [Test]
        public void Test_Multiply_Negative_Numbers()
        {
            var actual = _calc.Multiply(-42, -5);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: 210, actual);
        }

        [Test]
        public void Test_Multiply_Positive_And_Negative_Numbers()
        {
            var actual = _calc.Multiply(666, -9);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: -5994, actual);
        }

        [Test]
        public void Test_Multiply_By_Zerro()
        {
            var actual = _calc.Multiply(1_000_000, 0);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: 0, actual);
        }
        #endregion

        #region Raising_Test
        [Test]
        public void Test_Raising_Positive_Numbers()
        {
            var actual = _calc.Raising(6, 6);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: 46_656, actual);
        }

        [Test]
        public void Test_Raising_Negative_Raising()
        {
            var actual = _calc.Raising(-46_656, -6);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: 0, actual);
        }

        [Test]
        public void Test_Raising_Negativ_And_Positive_Numbers()
        {
            var actual = _calc.Raising(-2, 3);
            _mock.Verify(l => l.Log(It.IsAny<string>()), Times.Once());
            Assert.AreEqual(expected: -8, actual);
        }
        #endregion
    }
}