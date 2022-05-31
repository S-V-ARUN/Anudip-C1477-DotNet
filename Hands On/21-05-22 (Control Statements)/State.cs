// 2.) program to print ice ,water or steam state

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project1

{
  class State
    {
        static void Main(string[] args)

        {
            int temp;
            
            Console.Write("Enter temperature - ");
            temp = int.Parse(Console.ReadLine());
            

           if (temp == 0)
                Console.WriteLine("It is in Ice state ");
           else if (temp>0 && temp<100) 
                Console.WriteLine(" It is in Water State ");
           else
                Console.WriteLine(" It is in steam state ");
            
        }
    }
}