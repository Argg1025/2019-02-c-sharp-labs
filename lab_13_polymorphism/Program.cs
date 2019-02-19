using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Parent
    {
        //method
        void DoThis()
        {

        }
        // can override
        public virtual void DoThat()
        {
            
        }
    }

    
    public class Child : Parent
    {
        // can override parent method : polymorphism
        public override void DoThat()
        {
            //base.DoThat();
        }

    }
}
