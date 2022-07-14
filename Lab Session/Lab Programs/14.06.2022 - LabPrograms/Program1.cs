using System;
namespace ArrayBasedProgram
{
    /*Design, Develop and Implement a menu driven Program in C# for the following Array operations
    a. Creating an Array of N Integer Elements
    b. Display of Array Elements with Suitable Headings
    c. Inserting an Element (ELEM) at a given valid Position (POS)
    d. Deleting an Element at a given valid Position(POS)
    e. Searching an element present in array or not
    f. Exit.
    Support the program with functions for each of the above operations.*/

    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------     Program Question     ---------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Design, Develop and Implement a menu driven Program in C# for the following Array operations");
            Console.WriteLine("a. Creating an Array of N Integer Elements");
            Console.WriteLine("b. Display of Array Elements with Suitable Headings");
            Console.WriteLine("c. Inserting an Element (ELEM) at a given valid Position (POS)");
            Console.WriteLine("d. Deleting an Element at a given valid Position(POS)");
            Console.WriteLine("e. Searching an element present in array or not");
            Console.WriteLine("f. Exit.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------    Program Output     ---------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            int size = 20;
            int count = 0;
            // Actual array for doing operations 
            int[] accArr = new int[size];


            // method to view elements in array
            void ViewArray()
            {
                if (count == 0)
                {
                    Console.WriteLine("Array is empty ");
                }
                else
                {
                    Console.WriteLine("values of array are : ");
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(accArr[i]);
                    }
                }
            }

            // method to add a element in an array
            void AddElement()
            {
                try
                {
                    Console.Write("Enter How many values you wanna add : ");
                    int c1 = int.Parse(Console.ReadLine());
                    for (int i = 0; i < c1; i++)
                    {
                        Console.Write("Enter a number to add : ");
                        int insert = int.Parse(Console.ReadLine());
                        accArr[count] = insert;
                        count++;
                    }
                    
                }
                catch (FormatException e)
                {
                    Console.Write(e.Message);
                    Console.WriteLine(" , Enter only number");
                }
                finally
                {
                    Console.WriteLine("Array is Updated till the value u entered");
                }
            }

            // method to delete a element in an array
            void DeleteElement()
            {
                // temporary array for delete method
                int[] tempArr = new int[size];

                if (count == 0)
                {
                    Console.WriteLine("Array is empty , Can't Delete ");
                }
                else
                {
                    try
                    {
                        int c = 0;
                        Console.Write("Enter a number to delete : ");
                        int delete = int.Parse(Console.ReadLine());
                        int j = 0;
                        for (int i = 0; i < count; i++)
                        {
                            if (accArr[i] != delete)
                            {
                                tempArr[j] = accArr[i];
                                j++;

                            }
                            else
                            {
                                c = 1;
                                count--;
                            }


                        }
                        for (int i = 0; i < count; i++)
                        {
                            accArr[i] = tempArr[i];
                        }
                        if (c == 1)
                        {
                            Console.WriteLine("Updated array is : ");
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine(accArr[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine(" Number You entered is not present in array , can't delete");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(" , Enter only number");
                    }
                }
            }

            //method to search an element
            void SearchElement()
            {
                try
                {
                    Console.Write("Enter a element u wanna Find : ");
                    int c1 = int.Parse(Console.ReadLine());
                    int c2 = 0;
                    for (int i = 0; i < count; i++)
                    {
                        if (c1 == accArr[i])
                        {
                            c2 = 1;
                        }
                        if (c2 == 1)
                        {
                            Console.WriteLine("Element is Present in array in {0} index", i);
                            break;
                        }
                    }

                    if (c2 == 0)
                    {
                        Console.WriteLine("Element is not present in array");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(" , Enter only number");
                }
            }

            //flag variable for check the condition 
            char check = 'y';
            // do while loop to repeat the operation till condition becomes false
            do
            {
                Console.WriteLine("Enter 1 to view Values");
                Console.WriteLine("Enter 2 to add value");
                Console.WriteLine("Enter 3 to delete a value");
                Console.WriteLine("Enter 4 to search a element");
                int choice = int.Parse(Console.ReadLine());

                // four case to do 4 operations
                switch (choice)
                {
                    case 1:
                        {
                            ViewArray();
                            break;
                        }
                    case 2:
                        {
                            AddElement();
                            break;
                        }
                    case 3:
                        {
                            DeleteElement();
                            break;
                        }
                    case 4:
                        {
                            SearchElement();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter only correct Key");
                            break;
                        }
                }
                Console.WriteLine();
                //updation of flag variable
                Console.Write("Do u wanna continue : ");
                check = char.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
            }

            //condition for the loop
            while ((check == 'y') || (check == 'Y'));
        }


    }


}