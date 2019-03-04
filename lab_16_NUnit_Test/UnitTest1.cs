using NUnit.Framework;
using lab_16_NUnit_XUnit_Tests;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Lab_16_NUnit_Test_01()
        {
            var a = new TestMeNow();
            // arrange
            double expected01 = 36;
            // act
            var actual01 = a.TestThisMethodWorks(2, 3, 2);
            // assert
            Assert.AreEqual(expected01, actual01);
        }
    }
}