//Write a program to print the number is odd or even


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project1

{
  class OddorEven
    {
        static void Main(string[] args)

        {
            int num;
            Console.Write("Enter a number - ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("it is a even number");
            else
                Console.WriteLine(" it is a odd number");
            
        }
    }
}