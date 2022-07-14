using System;
/*Question 1

i ) Program to print the following format
1
2	3
4	5	6	
7	8	9	10

ii ) Use Constructor and Method Overloading*/
namespace LabCsharp
{
    class Program1
    {
         int a ;
        //Constructor 1 without parameters
        public Program1()
        {
            a = 1;
        }
        //Constructor 2 with Parameters
        public Program1(int b)
        {
            a = b;
        }
        //Show method without Parameters
       public void Show()
        {
            for(int i = 1; i<= 4; i++)
            {

                for(int j = 1; j<= i; j++)
                {
                    Console.Write(a++ + "   ");
                }
                Console.WriteLine();

            }
        }
        //Show method with Parameters
        public  void Show(int b)
        {
            int a1 = 1;
            for (int i = 1; i <= b; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(a1++ + "   ");
                }
                Console.WriteLine();

            }

        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Program1 program1 = new Program1();
            Console.WriteLine("Using Show Methods with Parameters");
            program1.Show(5);
            Console.WriteLine("Using Show Methods Without Parameters");
            program1.Show();
            Console.WriteLine("Using second Constructor");
            Program1 program2 = new Program1(2);
            program2.Show();
        }
    }
}