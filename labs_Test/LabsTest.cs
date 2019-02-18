using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_112_collections;

namespace labs_Test
{
    [TestClass]
    public class LabsTest
    {
        [TestMethod]
        public void Lab112CollectionsTest()
        {
            // arrange 
            var expected01 = 224;
            var expected02 = 22400;
            var instanceLab112Collection = new Collections();
            // act
            var actual01 = instanceLab112Collection.Collections20MinLab(1,2,3);
            var actual02 = instanceLab112Collection.Collections20MinLab(10, 20, 30);

            // assert
            Assert.AreEqual(expected01, actual01);
            Assert.AreEqual(expected02, actual02);
        }
    }
}
