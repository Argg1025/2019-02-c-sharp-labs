#define PHILTEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* NOTES:
 * BUILD > CONFIGURATION MANAGER > SET MODE TO RELEASE AND IFDEBUG WILL BE OMMITTED FROM YOUR CODE
 */

namespace Lab_17_debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting App");

#if DEBUG
            Console.WriteLine("This is Debug code");
#endif
            Console.WriteLine("Finishing App");
#if PHILTEST
            Console.WriteLine("If Phil is testing");

        }
    }
}