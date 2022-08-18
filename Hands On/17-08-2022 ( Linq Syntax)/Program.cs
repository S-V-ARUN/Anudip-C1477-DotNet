using System;
using System.Collections;
namespace Create
{
    class LINq
    {
        public static void Main(String[] args)
        {
            ArrayList a = new ArrayList();
            a.Add(100);
            a.Add("arun");
            a.Add(2.0);
            a.Add("DotNet");
            ArrayList a1 = new ArrayList();
            a1.Add(100);
            a1.Add(2000);
            a1.Add(50);
            a1.Add(10);
            //Linq Syntax
            var b = from c in a.OfType<String>() select c;
            var d = from int f in a1 where f>50 select f;
            foreach (var c in b)
            {
                Console.WriteLine(c);
            }
            foreach (int c in d)
            {
                Console.WriteLine(c);
            }
               
                
        }

    }


}