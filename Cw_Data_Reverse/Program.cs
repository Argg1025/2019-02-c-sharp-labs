using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_Data_Reverse
{
    class Program
    {

        static void Main(string[] args)
        {
            foreach (var num in Kata.DataReverse(new int[32] { 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0 }))
            {
                Console.Write(num);
            }
            
        }
    }
    // A stream of data is received and needs to be reversed. 
    // Each segment is 8 bits long, meaning the order of these segments needs to be reversed;
    // e.g input [1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0]
    // output [1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0]
    public class Kata
    {
        public static int[] DataReverse(int[] data)
        {
            List<int> nums = new List<int>();
            for (int i = data.Length / 8 - 1; i >= 0; i--)
            {
                for (int j = i * 8; j < i * 8 + 8; j++)
                {
                    nums.Add(data[j]);
                }
            }
            return nums.ToArray();
        }
    }
}
