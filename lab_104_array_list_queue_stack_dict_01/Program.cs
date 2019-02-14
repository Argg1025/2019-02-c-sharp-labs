using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_104_array_list_queue_stack_dict_01
{
    class Program
    {
        public static int[] numArray = new int[10];
        public static List<int> numList = new List<int>();
        public static Stack<int> numStack = new Stack<int>();
        public static Queue<int> numQueue = new Queue<int>();
        public static Dictionary<int, int> numDict =
            new Dictionary<int, int>();
        static void Main(string[] args)
        {
            // Put 10 numbers in array
            FillArray();
            // Move items to a list and add 1 to each item
            AddList();
            // Move to a stack and add 1
            AddStack();
            // Move to a queue and add 1
            AddQueue();
            // Move to a dictionary and add 1
            AddDict();
            // Return total
            Console.WriteLine(Total());
        }
        static void FillArray()
        {
            for (int i = 0; i < 10; i++)
            {
                numArray[i] = i + 1;
            }
        }

        public static void AddList()
        {
            foreach (var num in numArray)
            {
                numList.Add(num + 1);
            }
        }

        public static void AddStack()
        {
            foreach (var num in numList)
            {
                numStack.Push(num + 1);
            }
        }

        public static void AddQueue()
        {
            foreach (var num in numStack)
            {
                numQueue.Enqueue(num + 1);
            }
        }

        public static void AddDict()
        {
            foreach (var num in numQueue)
            {
                numDict.Add(num, num + 1);
            }
        }

        public static int Total()
        {
            int sum = 0;
            foreach (var key in numDict)
            {
                sum += key.Value;
            }
            return sum;
        }
    }
}
