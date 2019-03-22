using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_Round_To_Nearest_0._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Solution(3.56));
            Console.WriteLine(Kata.Solution(11.15));
            Console.WriteLine(Kata.Solution(100.89));
            Console.WriteLine(Kata.Solution(46.35));
        }
        public class Kata
        {
            public static double Solution(double n)
            {
                return Math.Round(n * 2) / 2;
            }
        }
    }
}
