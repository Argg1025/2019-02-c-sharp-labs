using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_16_NUnit_XUnit_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestMeNow();
            Console.WriteLine(a.TestThisMethodWorks(2,3,3));
        }
    }

    public class TestMeNow
    {
        public double TestThisMethodWorks(int x, int y, int p)
        {
            return Math.Pow((x * y), p);
        }
    }
}
