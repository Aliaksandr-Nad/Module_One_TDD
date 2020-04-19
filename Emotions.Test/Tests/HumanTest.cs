using Emotions.Emotions;
using NUnit.Framework;
using System.Diagnostics;
using Moq;
using Emotions.Emotions.Interface;

namespace Emotions.Test.Tests
{
    [TestFixture]
    public class HumanTest
    {
        private Human _human;
        private Mock<IEmotion> _mock;

        [SetUp]
        public void SetUp()
        {
            _mock = new Mock<IEmotion>();
            _human = new Human(_mock.Object);
        }

        [Test]
        public void Test_Human_Hello()
        {
            var _actual = _human.Hello();
            Assert.IsNotNull(_actual);
            Assert.AreEqual(expected: "\tHello\t\t\t\t\t", actual: _actual);
        }

        [Test]
        public void Test_Human_Feeling()
        {
            var _actual = _human.Feeling();
            Assert.IsNotNull(_actual);
            Assert.AreEqual(expected: "\t and u?\t", actual: _actual);
        }
    }
}
