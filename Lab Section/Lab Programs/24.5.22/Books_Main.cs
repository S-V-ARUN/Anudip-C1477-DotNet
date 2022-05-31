using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create

{
    class Books
    {
        string Title, Author_name;
        int Id;
        public Books()
        {
            this.Title = "";
            this.Author_name = "";
            this.Id = 00;

        }
        public Books(string title, string author_name, int id)
        {
            this.Title = title;
            this.Author_name = author_name;
            this.Id = id;
        }

        public void input()
        {
            Console.Write("Enter the Book Name :");
            Title = Console.ReadLine();

            Console.Write("Enter the Author Name :");
            Author_name = Console.ReadLine();

            Console.Write("Enter the Id :");
            Id = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("Book Details : Book Name - {0} , Author - {1} , Id - {2} ", Title, Author_name, Id);
        }

    }
    class Books_Main
    {
        static void Main(string[] args)

        {
            Books[] Obj = new Books[3];
            Console.WriteLine("Enter 3 books details");
            for (int i = 0; i < 3; i++)
            {
                Obj[i] = new Books();
                Obj[i].input();

            }

            Books Obj2 = new Books("GOT", "Jon Snow", 004);
            int a;
            Console.WriteLine(" To Show the list of books enter 1 or Any no to exit");
            a = int.Parse(Console.ReadLine());
            if (a == 1)
            {

                for (int i = 0; i < 3; i++)
                {
                    Obj[i].output();
                }
                Obj2.output();

            }
            else
            {
                Console.WriteLine("ThankYou");
            }






        }


    }


}
