using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_103_production_line_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var parents = new List<Parent>();
            string[] parentArray = { "adam", "bob", "alice", "bill", "paul", "jeff", "carmel", "rachel", "jess", "ben" };
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                string randName = parentArray[rnd.Next(10)];
                int randAge = rnd.Next(100);
                //DateTime;
                parents.Add(new Parent());
            }
        }

   
    }
    class Parent
    {
        string Name { get; set; }
        int Age { get; set; }
        DateTime Dob { get; set; }

        public Parent() { }

        Parent(string name, int age, DateTime dob)
        {
            this.Name = name;
            this.Age = age;
            this.Dob = dob;
        }
    }
}
