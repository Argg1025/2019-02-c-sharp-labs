using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_113_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Arraylist();
            Console.WriteLine(a.arrayListMethod(1,2,3,4));
            Console.WriteLine(a.arrayListMethod(10, 20, 30, 40));
        }
    }

    public class Arraylist
    {
        public static int[] numArray = new int[4];
        public static List<int> numList = new List<int>();
        public static Stack<int> numStack = new Stack<int>();
        public static Queue<int> numQueue = new Queue<int>();
        public static Dictionary<int, int> numDict = new Dictionary<int, int>();
        public static ArrayList numArrayList = new ArrayList();

        public int arrayListMethod(int a, int b, int c, int d)
        {


            /*
             accept 4 integers
             put to Array
             extract ==> double put to a Queue
             extract ==> double put to Stack
             extract ==> square ==> put to Dict
             put to ARRAYLIST
             extract and get the sum of the items and return this sum
             */

            int sum = 0;
            numArray[0] = a;
            numArray[1] = b;
            numArray[2] = c;
            numArray[3] = d;


            numQueue.Clear();
            foreach (var num in numArray)
            {
                numQueue.Enqueue(num * 2);

            }

            numStack.Clear();
            foreach (var num in numQueue)
            {
                numStack.Push(num * 2);
            }
            

            numDict.Clear();
            foreach (var num in numStack)
            {
                numDict.Add(num, num * num);
            }

            numArrayList.Clear();
            foreach (var key in numDict)
            {
                numArrayList.Add(key.Value);
            }

            foreach (int num in numArrayList)
            {
                sum += num;
            }

            return sum;
        }
    }
}
