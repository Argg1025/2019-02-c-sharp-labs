using NUnit.Framework;
using Sum_Hw;
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
        public void Check_Sum()
        {
            var instance = new SumMethod();
            Assert.AreEqual(5, instance.Sum(3, -1));
            Assert.AreEqual(3, instance.Sum(3, 3));
            Assert.AreEqual(55, instance.Sum(0, 10));
            Assert.AreEqual(-5, instance.Sum(-3, -2));
            Assert.AreEqual(0, instance.Sum(-10, 10));
        }
    }
}