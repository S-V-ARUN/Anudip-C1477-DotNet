using System;
using System.Collections;
namespace Collections
{
    class StackTest
    {
        Stack s1 = new Stack();
        void Addelements()
        {
            Console.WriteLine("Entering Values Values in Stack");
            s1.Push(5);
            s1.Push(6);
            s1.Push(7);
            s1.Push(8);
            s1.Push(9);



        }
        public void ShowElement()
        {
            Addelements();
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Pop , Last Element Got Removed in Queue");
            s1.Pop();
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek Method to View the Last Element : "+s1.Peek());
        }

    }
    
        class MainClass
        {
            static void Main(string[] args)
            {
               
                Console.WriteLine("Stack Based Program");
                StackTest ob = new StackTest();
                ob.ShowElement();
                
            }
        }

    }
