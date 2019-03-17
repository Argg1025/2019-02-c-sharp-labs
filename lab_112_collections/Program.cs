using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_112_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var instanceLab112Collection = new Collections();
            Console.WriteLine(instanceLab112Collection.Collections20MinLab(10, 20, 30));
            
        }
    }

    public class Collections
    {
        /* Receive 3 numbers 
         * 
         * Put these 3 numbers into an array
         * 
         * Output the numbers, double each one and store in a Stack
         * 
         * Repeat i.e. Output numbers, double and store in a QUEUE
         * 
         * Output numbers, SQUARE THEM then store in List<int>
         * 
         * Add up numbers in the List<int> and return total
        */

        public static int[] numArray = new int[3];
        public static List<int> numList = new List<int>();
        public static Stack<int> numStack = new Stack<int>();
        public static Queue<int> numQueue = new Queue<int>();

        public int Collections20MinLab(int num1, int num2, int num3)
        {
            int sum = 0;
            numArray[0] = num1;
            numArray[1] = num2;
            numArray[2] = num3;

            numStack.Clear();
            foreach (var num in numArray)
            {
                numStack.Push(num * 2);
            }
            numQueue.Clear();
            foreach (var num in numStack)
            {
                numQueue.Enqueue(num * 2);

            }

            numList.Clear();
            foreach (var num in numQueue)
            {
                double d = num;
                double pow = Math.Pow(d, 2);
                numList.Add((int)pow);
            }
            
            foreach (var num in numList)
            {
                sum += num;
            }

            return sum;
        }
    }
}
