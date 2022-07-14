// 3.)write a program to check positive or negative


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project1

{
  class Pos_or_Neg
    {
        static void Main(string[] args)

        {
            int num;
            Console.Write("Enter a number - ");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
                Console.WriteLine("{0} is Positive Number",num);
            else
                Console.WriteLine("{0} is Negative number", num);
            
        }
    }
}