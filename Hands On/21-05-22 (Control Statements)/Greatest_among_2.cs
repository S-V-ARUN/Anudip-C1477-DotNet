// 4.)write a program to find biggest among two numbers


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project1

{
  class Greatest_among_2
    {
        static void Main(string[] args)

        {
            int num1;
            int num2;
            Console.Write("Enter a number - ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number - ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine("{0} is greater than {1}",num1,num2);
            else
                Console.WriteLine("{0} is greater than {1}", num2,num1);
            
        }
    }
}