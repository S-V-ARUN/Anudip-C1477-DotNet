using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication6
{
    class BaseClass
    {
        protected int baseVar_A;
       
        public virtual void display()
        {
            Console.WriteLine("Value of baseVar_A = " + baseVar_A);
        }
    }


    class DerivedClass : BaseClass
    {
        int derivedVar_B;

        public DerivedClass(int a, int b)
        {
            baseVar_A = a;
            this.derivedVar_B = b;
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("Value of derivedVar_B = " + derivedVar_B);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass(15, 16);
            derivedClass.display();
        }
    }
}