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

        [Test]
        public void Test_Human_EvilHello()
        {
            Mock<BaseEmotions> _mock = new Mock<BaseEmotions>();
            _human = new Human(_mock.Object);

            var _actual = _human.EvilHello();
            Assert.IsNotNull(_actual);
            Assert.AreEqual(expected: "\tHello\t\t\t\t\t", actual: _actual);
        }

        [Test]
        public void Test_Human_EvilFeeling()
        {
            Mock<BaseEmotions> _mock = new Mock<BaseEmotions>();
            _human = new Human(_mock.Object);

            var _actual = _human.EvilFeeling();
            Assert.IsNotNull(_actual);
            Assert.AreEqual(expected: "\t and u?\t", actual: _actual);
        }

        [Test]
        public void Test_Human_HappyHello()
        {
            Mock<BaseEmotions> _mock = new Mock<BaseEmotions>();
            _human = new Human(_mock.Object);

            var _actual = _human.HappyHello();
            Assert.IsNotNull(_actual);
            Assert.AreEqual(expected: "\tHello\t\t\t\t\t", actual: _actual);
        }

        [Test]
        public void Test_Human_HappyFeeling()
        {
            Mock<BaseEmotions> _mock = new Mock<BaseEmotions>();
            _human = new Human(_mock.Object);

            var _actual = _human.HappyFeeling();
            Assert.IsNotNull(_actual);
            Assert.AreEqual(expected: "\t and u?\t", actual: _actual);
        }

        [Test]
        public void Test_Human_FearFeeling()
        {
            Mock<FearEmotion> _mock = new Mock<FearEmotion>();
            _human = new Human(_mock.Object);

            var _actual = _human.HappyFeeling();
            Assert.IsNotNull(_actual);
            Assert.AreEqual(expected: "\t and u?\t", actual: _actual);
        }
    }
}
