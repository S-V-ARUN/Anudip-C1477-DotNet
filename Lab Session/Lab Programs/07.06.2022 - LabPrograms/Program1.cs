using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Laptop
    {
           protected string Brand ;
        protected string spec ;
        public abstract void display();
        
    }
    class SampleClass_B : Laptop
    {
        public SampleClass_B()
        {
           
            Brand = "Dell";
            spec = "i5 core";
        }
        public override void display()
        {
            Console.WriteLine("your brand name is:  " + Brand);
            Console.WriteLine("your spec is:  " + spec);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SampleClass_B obj = new SampleClass_B();
            obj.display();
            Console.ReadLine();
        }
    }
}
