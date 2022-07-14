using System;
using System.Collections;
namespace Collections
{
    class ALTest
    {
        //Declaring HashTable
        Hashtable ht = new Hashtable();
        void AddElements()
        {
            ht.Add("a", 1);
            ht.Add("b", 2);
            ht.Add("c", 3);
            ht.Add("d", 4);
            ht.Add("e", 5);
            ht.Add("f", 6);
            ht.Add("g", 7);
            ht.Add("h", 8);
            ht.Add("i", 9);
            ht.Add("j", 10);
            
        }

        void ShowElements()
        {
            foreach (DictionaryEntry dr in ht)
            {
                Console.WriteLine("Key is "+ dr.Key + " and Value is "+dr.Value);
            }
        }
        public void ObjShow()
        {
            AddElements();
            Console.WriteLine("Key Elements are ");
            ShowElements();
            Console.WriteLine("After Removing using key a ");
            ht.Remove("a");
            ShowElements();
            Console.WriteLine("After Clearing all elements");
            ht.Clear();
            ShowElements();
        }
    }

    class MainClass
        {
            static void Main(string[] args)
            {
                Console.WriteLine("HashTable Based Program");
                ALTest ob = new ALTest();
                ob.ObjShow();
                
            }
        }

    }
