using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_16_NUnit_XUnit_Tests;
using System;

namespace lab_16_MSTest
{
    

    [TestClass]
    public class Lab_16_Test_Class
    {
        [TestInitialize]
        public void Initialize()
        {
            Console.WriteLine("Initializing Tests");
        }

        [TestMethod]
        public void TestLab16UsingMSTest()
        {
            var a = new TestMeNow();
            // arrange
            double expected01 = 216;
            // act
            var actual01 = a.TestThisMethodWorks(2, 3, 3);
            // assert
            Assert.AreEqual(expected01, actual01);
        }
    }
}
