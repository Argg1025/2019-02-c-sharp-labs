using NUnit.Framework;
using lab_121_hash_set_to_excel;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /*
         * Start a stopwatch
         Pass 3 numbers to an array
         Double numbers and pass to a LINKED LIST
         Double the numbers and pass to a HASH SET
         Add 15, treble numbers and pass to a DICTIONARY
         Stop the stopwatch.
         Return the test as a CUSTOM OBJECT CONTAINING
            ElapsedTime(integer, will be in milliseconds)
            First number
            Second number
            Third number
        Test passes if stopwatch time less than time passed in (4th variable) (set to 10 seconds)
        Not part of the test
        Output all values to .csv text file and append to existing file.
            DATETIME STAMP
            INPUT 4 PARAMS
            OUTPUT 4 PARAMS
        Finally launch excel to read this file using Process.Start...
             */

        [TestCase(10,20,30,10000)]
        public void HashSetExcelTest1(int a, int b, int c, int d)
        {
            HashSetToExcel method = new HashSetToExcel();
            Assert.LessOrEqual(method.HashSetToTest(a,b,c).elapsed, d);
        }
    }
}