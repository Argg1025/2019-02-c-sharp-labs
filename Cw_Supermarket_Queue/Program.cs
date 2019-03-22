using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_Supermarket_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100)); 
        }
    }

    // The method takes an array of queuing times of each successive customer and the number of tills.
    // Each customer joins the next available till.
    // You must return the total time it takes for all customers to finish checking out their groceries.
    public class Kata
    {
        public static long QueueTime(int[] customers, int n)
        {
            int[] longest = new int[n];
            long max;
            if (customers.Length > 0)
            {
                foreach (var num in customers)
                {
                    longest[Array.IndexOf(longest, longest.Min())] += num;
                }
                max = longest.Max();
            }
            else
            {
                max = 0;
            }
            return max;
        }

    }
}
