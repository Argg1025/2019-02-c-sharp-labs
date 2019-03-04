using System;
using Xunit;
using lab_16_NUnit_XUnit_Tests;

namespace lab_16_XUnit_Test
{
    public class Lab_16_XUnit_Tests
    {
        [Fact]
        public void Lab_16_Test_Math_Power()
        {
            var a = new TestMeNow();
            // arrange
            double expected01 = 36;
            // act
            var actual01 = a.TestThisMethodWorks(2, 3, 2);
            // assert
            Assert.Equal(expected01, actual01);
        }
    }
}
