using System;
namespace Library
{
    class Book
    {
        int bookCount;
        internal string bookName;
        public static int i1;

        public void AddNew(string b1name)
        {

            bookName = b1name;
            bookCount++;
            Console.WriteLine("New Book Found ,Book added successfully");
   
        }

        public void AddOld(Book[] tobj, string b1Name)
        {
            int c1 = 0;
            for (int i = 0; i <= i1; i++)
            {
                if (tobj[i].bookName == b1Name)
                {

                    c1++;
                    tobj[i].bookCount++;
                    Console.WriteLine("{0} is already existing so count of {0} increase by {1}", tobj[i].bookName, tobj[i].bookCount);
                    break;
                }
            }
            


        }
        public static void BorrowBook(Book[] tobj, string b1Name)
        {
            int c1 = 0;
                for (int i = 0; i < i1 ; i++)
                {
                    if (tobj[i].bookName == b1Name && tobj[i].bookCount > 0)
                    {

                        
                        tobj[i].bookCount--;
                        Console.WriteLine("You have borrowed {0} book , available count is {1}", tobj[i].bookName, tobj[i].bookCount);
                        c1 = 1;
                        break;
                        
                    }
                }
            
            if(c1 == 0)
            {
                Console.WriteLine("{0} book is not currtently available ", b1Name);

            }

        }

        public static void ReturnBook(Book[] tobj, string b1Name)
        {
            for (int i = 0; i < i1; i++)
            {
                if (tobj[i].bookName == b1Name)
                {
                    tobj[i].bookCount++;
                    Console.WriteLine("ThankYou for returning {0} book , available count is {1}", tobj[i].bookName, tobj[i].bookCount);
                    
                    break;
                    
                }
                
            }
        }

        public static void ViewBooks(Book[] tobj)
        {
            for (int i = 0; i < i1; i++)
            {
                Console.WriteLine("Bookname = {0} / Available count = ({1})", tobj[i].bookName, tobj[i].bookCount);
            }
        }




    }
   
        

       

   
    class Program
    {
        static void Main(string[] args)
        {   
            int j = 0;
            Book[] obj = new Book[20];
            char iCheck = 'y';
            int i1 = 0;
            int maxQ = 1;
            string bname1 = "";
            do
            {
            Console.WriteLine("Enter 1 to add book");
            Console.WriteLine("Enter 2 to View available books");
            Console.WriteLine("Enter 3 to borrow book");
            Console.WriteLine("Enter 4 to return book");
            Console.WriteLine("Enter 5 to Quit");

            int choice = int.Parse(Console.ReadLine());
            
            
            

            switch (choice)
            {
                case 1:
                    {
                        
                        Console.Write("Enter name of the Book u wanna add : ");
                        string bName2 = Console.ReadLine();
                            int c1 = 0;
                            for (int i = 0; i < j; i++)
                            {
                                if (bName2 == obj[i].bookName) 
                                { 
                                   
                                    obj[i].AddOld(obj, bName2);
                                    c1 = 1;
                                    break;
                                }

                            } 
                            if(c1 == 0)
                            {
                                
                                obj[j] = new Book();
                                obj[j].AddNew(bName2);

                                j++;
                                Book.i1++;
                                

                            }
                            break;

                        }
                case 2:
                    {
                        Book.ViewBooks(obj);
                        break;
                    }
                case 3:
                    {
                        if (maxQ == 1)
                        {
                            Console.Write("Enter name of the Book u wanna Borrow : ");
                            string bName2 = Console.ReadLine();
                            Book.BorrowBook(obj, bName2);
                            bname1 = bName2;
                            maxQ = 2;

                        }
                        else
                        {
                            Console.WriteLine("You already Borrowed a book Return it First ");
                        }
                        break;
                    }
                case 4:
                    {
                        Console.Write("Enter name of the Book u wanna return : ");
                        string bName2 = Console.ReadLine();

                        if (bname1 == bName2)
                        {
                            Book.ReturnBook(obj, bName2);
                                maxQ = 1;
                        }
                        else
                        {
                            Console.WriteLine("You are returning Wrong book ");
                        }
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Thanks for using DigiLibrary");
                        break;

                    }

            }
            
                try
                {
                    Console.WriteLine("Do u wanna Continue ");
                    iCheck = char.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please Use only y or n (only one letter conformation is accepted )");
                }
            }
            while (iCheck == 'y' || iCheck == 'Y');

            Console.WriteLine("Thanks For Visiting");
        }



    }
}