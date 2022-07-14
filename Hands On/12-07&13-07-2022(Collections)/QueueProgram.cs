using System;
using System.Collections;
namespace Collections
{
    class QueueTest
    {
        Queue s1 = new Queue();
        void Addelements()
        {
            Console.WriteLine("Entering Values Values in Queue");
            s1.Enqueue(5);
            s1.Enqueue(6);
            s1.Enqueue(7);
            s1.Enqueue(8);
            s1.Enqueue(9);
            


        }
        public void ShowElement()
        {
            Addelements();
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Dequeue , First Element Got Removed in Queue");
            s1.Dequeue();
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek Method to View the First Element : "+s1.Peek());
        }

    }
    
        class MainClass
        {
            static void Main(string[] args)
            {
               
                Console.WriteLine("Queue Based Program");
                QueueTest ob = new QueueTest();
                ob.ShowElement();
                
            }
        }

    }
