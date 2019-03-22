using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_31_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var P01 = new Point(10, 10);
            var P02 = new Point(20, 20);
        }
    }

    class x { }

    struct Point
    {
        public int X;
        public int Y;
        
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

}
