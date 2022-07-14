using System;
//Running two methods using delegate
//declaring Delegate
public delegate void TablesDelegate();
namespace DelegateTest
{
    class TablesClass
    {
        //method for two table calculation
        public static void Tables3()
        {
            Console.WriteLine("3 tables to 10");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("3*{0}={1}",i,3*i);
            }
        }
        //method for three table calculation
        public static void Tables5()
        {
            Console.WriteLine("5 tables to 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("5*{0}={1}", i, 5 * i);
            }
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            //creating object for delegate
            TablesDelegate t1 = new TablesDelegate(TablesClass.Tables3);
            //binding method to delegate
            t1 += TablesClass.Tables5;
            //invoking delegate
            t1.Invoke();
        }
    }

}
