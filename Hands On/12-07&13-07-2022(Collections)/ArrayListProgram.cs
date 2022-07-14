using System;
using System.Collections;
namespace Collections
{
    class ALTest
    {
        //Declaring Array List
        ArrayList al = new ArrayList();

        void AddElements()
        {
            for (int i = 1; i <= 10; i++)
            {
                al.Add(i * 10);
            }
        }

        void ShowElements()
        {
            foreach (var hlo in al)
            {
                Console.WriteLine(hlo);
            }
        }
        public void ObjShow()
        {
            AddElements();
            Console.WriteLine("Ten Tables");
            ShowElements();
            Console.WriteLine("After Sorting");
            al.Sort();
            ShowElements();
            Console.WriteLine("After Reversing");
            al.Reverse();
            ShowElements();
        }
    }

    class MainClass
        {
            static void Main(string[] args)
            {
               
                Console.WriteLine("ArrayList Based Program");
                ALTest ob = new ALTest();
                ob.ObjShow();
                
            }
        }

    }
