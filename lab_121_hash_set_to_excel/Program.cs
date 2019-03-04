using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_121_hash_set_to_excel
{
    class Program
    {

        static void Main(string[] args)
        {
            HashSetToExcel a = new HashSetToExcel();
            a.HashSetToTest(1, 2, 3);



        }


    }

    public class HashSetToExcel
    {
        public Custom HashSetToTest(int a, int b, int c) {
            Stopwatch s = new Stopwatch();
           
            int[] numArray = new int[3];
            numArray[0] = a;
            numArray[1] = b;
            numArray[2] = c;
            LinkedList<int> numList = new LinkedList<int>();
            HashSet<int> numSet = new HashSet<int>();
            Dictionary<int, int> numDict = new Dictionary<int, int>();
            s.Start();
            foreach (var num1 in numArray)
            {
                numList.AddLast(num1 * 2);
            }
            foreach (var num2 in numList)
            {
                numSet.Add(num2 * 2);
            }
            int i = 0;
            foreach (var num3 in numSet)
            {
                numDict.Add(i, (num3 + 15) * 3);
                i++;
            }
            s.Stop();
            Console.WriteLine($"a:{numDict[0]}\nb:{numDict[1]}\nc:{numDict[2]}\nelapsedTime:{s.ElapsedMilliseconds}");
            return new Custom(numDict[0], numDict[1], numDict[2], (int)s.ElapsedMilliseconds);
        }
    }

    public class Custom
    {
        public int first, second, third, elapsed;
        public Custom() { }
        public Custom(int a, int b, int c, int d)
        {
            first = a;
            second = b;
            third = c;
            elapsed = d;
        }
        
    }


}
