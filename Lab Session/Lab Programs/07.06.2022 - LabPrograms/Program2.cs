using System;
namespace Create
{
    interface i1
    {
        void Get();

    }
    interface i2
    {
        void Sum();
    }
    class A1 : i1 ,i2
    {
        int a,b,c;
        public void Get()
        {
            Console.Write("Enter a number : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter another number : ");
            b = int.Parse(Console.ReadLine());
        }
        public void Sum()
        {
            c = a + b;
            Console.WriteLine("Addition is "+c);
        }
        public void Show()
        {
            Get();
            Sum();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A1 a1 = new A1();
            a1.Show();
        }
    }


  
}
