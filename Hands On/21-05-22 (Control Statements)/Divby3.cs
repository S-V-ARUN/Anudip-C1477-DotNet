// 2.) write a given program is divisible by 3 or not


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test

{
  class Divby3
    {
        static void Main(string[] args)

        {
            int num;
            Console.Write("Enter a number - ");
            num = int.Parse(Console.ReadLine());
            if (num % 3 == 0)
                Console.WriteLine("{0} is divisible by 3",num);
            else
                Console.WriteLine("{0} is not divisible by 3", num);
            
        }
    }
}