using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Hw
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        
    }
    public class SumMethod
    {
        public int Sum(int a, int b)
        {
            int high, low, sum = 0;
            high = Math.Max(a, b);
            low = Math.Min(a, b);
            for (int i = low; i <= high; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
