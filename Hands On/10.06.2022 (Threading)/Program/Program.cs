using System;
//importing threding class
using System.Threading;
//program is for accessing one method with two threads  
namespace Threading1
{
    class ThreadTest
    {
        static object ob1 = new object();

        public static void work()
        {

            //running state
            for (int i = 0; i < 5; i++)
            {
                // using monitor so another thread cant disture the working thread
                // entering the working code, if one thread is working this code other thread can't enter till exit
                Monitor.Enter(ob1);
                {
                    try
                    {
                        Console.WriteLine("Hello World " + "Updated by " + Thread.CurrentThread.ManagedThreadId);
                        //non runnable state
                        Thread.Sleep(1000);
                    }
                    // if runtime error occurs in try block catch block get execute program will not stop
                    catch
                    {
                        Console.WriteLine("Error Occurs");
                    }
                    //exiting the code
                    finally { Monitor.Exit(ob1); }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //unstarted state
            Thread obj1 = new Thread(ThreadTest.work);
            Thread obj2 = new Thread(ThreadTest.work);
            //ready state
            obj1.Start();
            obj2.Start();


            //dead state - we cant call the same thread again because the thread is dead ,the thread can be used only once

        }
    }



}
