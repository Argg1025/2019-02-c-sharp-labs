using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_14_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            BluePrint b01 = new BluePrint();
            House h01 = new House();        // INSTANTIATION
            // b01 and h01 are both objects
            h01.numFloors = 2;
            h01.Length = 3.45;
            h01.numWindows = 10;
        }
    }

    class BluePrint
    {
        public string field01;
        public int field02;
    }

    // INSTRUCTIONS TO BUILD HOUSE
    class House
    {
        public int numFloors;
        public int numWindows;
        public double Length { get; set; }
    }
}
