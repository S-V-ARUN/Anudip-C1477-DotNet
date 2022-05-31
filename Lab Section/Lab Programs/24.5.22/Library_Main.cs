using System;
namespace Test
{
    class Library
    {
        int acc_num, duedate, issueddate;
        string title, author;

        public Library(int date1)
        {
            issueddate = date1;
            duedate = date1 + 10;
        }



        void icreate()
        {
            Console.Write("Enter account number : ");
            acc_num = int.Parse(Console.ReadLine());
            Console.Write("Enter Book title : ");
            title = Console.ReadLine();
            Console.Write("Enter Book author : ");
            author = Console.ReadLine();
        }

        void icompute(int submitedate)
        {
            if (submitedate > duedate)
            {
                int xsday = submitedate - duedate;
                int fine = (xsday) * 2;
                Console.WriteLine("The book was issued on {0}", issueddate);
                Console.WriteLine("You had 10 days to return back but you took {0} so u finned for those {1} day ", xsday + 10, xsday);
                Console.WriteLine("Your fine amount is Rs {0}", fine);
            }
            else
            {
                Console.WriteLine("You submitted book on time so no issues . Thanks for the Cooperatation ");
            }

        }

        public void iout()
        {
            int a;
            icreate();
            Console.WriteLine("Your Account number is {0}", acc_num);
            Console.WriteLine("Book details : Title - {0} , Author - {1}", title, author);
            Console.Write("Enter the Submittion date : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Issued Date - {0} , Submitted {1}", issueddate, a);
            icompute(a);


        }



    }


    class Library_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Team1's Library ;p");
            Library Obj1 = new Library(5);
            Obj1.iout();
            Console.WriteLine("Thanks for visiting  :)");

        }
    }
}
