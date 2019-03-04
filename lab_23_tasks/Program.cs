using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_23_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // latest way of running a task

            Task.Run( () => {
                Console.WriteLine("Running a background task 1");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Finishing task 1");
            });

            Task.Run(() => {
                Console.WriteLine("Running a background task 2");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Finishing task 2");
            });

            for (int i = 3; i < 5; i++)
            {
                Task.Run(() => {
                    Console.WriteLine($"Running a background task {i}");
                    System.Threading.Thread.Sleep(5000);
                   Console.WriteLine($"Finishing task {i}");
                });
            }

            // next most recent method

            var task01 = new Task( ()=> {
                Console.WriteLine("Task01 is running");
            });
            task01.Start();

            // slightly older

            var task02 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Task 02 (Factory.Start) is running");
            });

            // passing in a delegate

            // Action delegate which  DOES AN ACTION (DOES SOMETHING) BUT RETURNS VOID

            var task03 = new Task( new Action(ActionMethod));
            task03.Start();

            // repeat but add in a proper declared action variable

            var ActionMethod02 = new Action(ActionMethod);
            // or (quicker)
            Action ActionMethod03 = ActionMethod;

            var task04 = new Task(ActionMethod03);
            task04.Start();




            Console.WriteLine("All done");

            Console.ReadLine();
        }

        static void ActionMethod()
        {
            Console.WriteLine("Action Method does something but returns nothing");
        }

        public char[,] Pyramid(int height, int width) {
            char[,] pyramid = new char[height, width];
            //some code to make it work, good luck 
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j < (width - (2 * (i+1) - 1)) / 2 || j > (width + (2 * (i + 1) - 1)) / 2)
                    {
                        pyramid[i, j] = ' ';
                    }
                    else
                    {
                        pyramid[i, j] = '*';
                    }
                }
            }
            
            return pyramid;
        }
    }
}
