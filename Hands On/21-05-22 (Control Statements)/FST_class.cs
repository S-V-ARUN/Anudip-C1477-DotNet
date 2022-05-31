// 3.) Program to print first class,second class,third class ,pass or fail in exam

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project1

{
  class FST_class
    {
        static void Main(string[] args)

        {
            int mark;
            
            Console.Write("Enter Mark Out off 100 - ");
            mark = int.Parse(Console.ReadLine());


            if (mark > 80)
                Console.WriteLine(" Congratulation You cleared with first class ");
            else if (mark <= 80 && mark > 70)
                Console.WriteLine(" You cleared with Second class ");
            else if (mark <= 70 && mark > 60)
                Console.WriteLine(" You cleared with Third class ");
            else if (mark <= 60 && mark >= 50)
                Console.WriteLine(" You passed the exam ");
            else
                Console.WriteLine(" Sorry :( You failed the exam . Better Luck next time ");
            
        }
    }
}