// 1.) greates among 3 numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project1

{
  class Greatest_among_3
    {
        static void Main(string[] args)

        {
            int n1,n2,n3;
            
            Console.Write("Enter first number - ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number - ");
            n2 = int.Parse(Console.ReadLine()); 
            Console.Write("Enter third number - ");
            n3 = int.Parse(Console.ReadLine());

            if (n1>n2 && n1>n3)
                Console.WriteLine("{0} is greater than {1} and {2} ",n1,n2,n3);
           else if (n2>n3) 
                Console.WriteLine("{0} is greater than {1} and {2} ",n2,n1,n3);
            else
                Console.WriteLine("{0} is greater than {1} and {2} ", n3, n1, n2);
            
        }
    }
}