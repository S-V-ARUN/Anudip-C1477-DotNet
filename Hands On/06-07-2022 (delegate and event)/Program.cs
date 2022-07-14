using System;
namespace Test
{
    class Dec
    {
        public delegate void DecDelegate(int a);
        public event DecDelegate DecEvent;

       public void OpeFunction(int a)

       {
            if ((a %2) == 0)
            {
                Console.WriteLine("Number is divisible by 2");
            }
            else if((a %3) == 0)
            {
                Console.WriteLine("Number is Divisible By 3");
            }
            else
            {
                Console.WriteLine("Number is not Divisible by 2 & 3 ");
            }
       }
        public void Show()
        {
            Console.WriteLine("Enter a number to check");
            int a = int.Parse(Console.ReadLine());
            DecEvent(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dec obj = new Dec();
            obj.DecEvent += new Dec.DecDelegate(obj.OpeFunction);
            obj.Show();
        }
    }

}