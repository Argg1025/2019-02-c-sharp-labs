using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_101_speed_typing_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random();
            //Alphabet();
        }

        public static void Random()
        {
            string abc = "abcdefghijklmnopqrstuvwxyz", word = "";
            int score = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Please enter your word: ");
            while (stopWatch.ElapsedMilliseconds < 10000)
            {
                word += Console.ReadKey().KeyChar;

            }

            for (int i = 0; i < word.Length; i++)
            {
                if (abc.Contains(word[i]))
                {
                    score++;
                }
            }
            stopWatch.Stop();
            Console.WriteLine("\nYour score is " + score.ToString());
            Console.WriteLine("Press Enter to end game.");

            Console.ReadLine();

        }

        public static void Alphabet()
        {
            string abc = "abcdefghijklmnopqrstuvwxyz", word = "";
            int score = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Please enter your word: ");
            while (stopWatch.ElapsedMilliseconds < 10000)
            {
                word += Console.ReadKey().KeyChar;

            }
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == abc[i % 26])
                {
                    score++;
                }
            }

            stopWatch.Stop();
            Console.WriteLine("Your score is " + score.ToString());
            Console.ReadLine();

        }

    }
}
