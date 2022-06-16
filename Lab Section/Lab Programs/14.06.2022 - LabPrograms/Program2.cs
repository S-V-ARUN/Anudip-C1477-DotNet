using System;
namespace MulitDimentionalArray
{
    //Class for transpose the array
    class TransposeArray
    {
        int[,] arr1 = new int[2,3];
        // method to get data
        void GetData()
        {   
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter a numer : ");
                    int tempVar = int.Parse(Console.ReadLine());
                    arr1[i,j] = tempVar;
                }
            } 
        } 
        // method to perform Transpose operation
        void Transpose()
        {
            Console.WriteLine("Array Before Transpose");
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(arr1[j, i] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Array After Transpose");

            for (int j = 0; j < 3; j++)
            {
                for(int i = 0; i < 2; i++)
                {
                    Console.Write(arr1[i,j] + "\t") ;
                }
                Console.WriteLine ();
            }
        }
        //method to call the functions
       public void Show()
        {
            GetData();
            Transpose();
        }
    }
    // class for Merging of two array 
    class MergeArrays
    {   
        int [] arr1 = new int[3];
        int [] arr2 = new int[3];

        // method for get data
        void Getdata()
        {
            Console.WriteLine("Enter Values for first Array : ");
            Console.WriteLine();
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Enter a number : ");
                int TempVar = int.Parse(Console.ReadLine());
                arr1[i] = TempVar;

            }
            Console.WriteLine();
            Console.WriteLine("First array : ");
            for (int j = 0; j < arr1.Length; j++)
            {
                Console.Write(arr1[j] + "\t");

            }
            Console.WriteLine () ;
            Console.WriteLine("Enter Values for Second Array : ");
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("Enter a number : ");
                int TempVar = int.Parse(Console.ReadLine());
                arr2[i] = TempVar;
            }
            Console.WriteLine();
            Console.WriteLine("Second array : ");
            for (int j = 0; j < arr2.Length; j++)
            {
                Console.Write(arr2[j] + "\t");

            }
            Console.WriteLine();



        }
        //method for Merge arrays
        void MergeArray()
        {
            int mergeLength = arr1.Length + arr2.Length;
            int pos = 0;
            int [] arr3 = new int[mergeLength]; 
            for(int i = 0; i < arr1.Length; i++)
            { 
                arr3[pos] = arr1[i];
                pos++;
               
            }
            for(int j = 0; j < arr2.Length; j++)
            {
                arr3[pos] = arr2[j];
                pos++;
            }
            Console.WriteLine();
            Console.WriteLine("Merged Array is : ");
            Console.WriteLine();
            for(int i = 0; i < mergeLength; i++)
            {
                Console.Write(arr3[i] + "\t");
            }
            Console.WriteLine();

        }
        // method to call the functions
       public void Show2()
        {
            Getdata();
            MergeArray();
        }
    }

    // class for row column addition
    class RCAddition
    {
        int[,] arr1 = new int[2, 2];
        // method for get data
        void GetData()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Enter a numer : ");
                    int tempVar = int.Parse(Console.ReadLine());
                    arr1[i, j] = tempVar;
                }
            }
        }
        // method for row addition
        void RowAdd()
        {
            Console.WriteLine("Row addition");
            for (int i = 0; i < 2; i++)
            {
                int rAdd = 0;
                for( int j = 0; j < 2; j++)
                {
                    rAdd = rAdd + arr1[i, j];
                    

                }
                Console.Write(rAdd + "\t");
            }
            Console.WriteLine();
        }
        // method for column addition
        void ColAdd()
        {
            Console.WriteLine("Column addition");
            for (int i = 0; i < 2; i++)
            {    
                int cAdd = 0;
                for (int j = 0; j < 2; j++)
                {

                    cAdd = cAdd + arr1[j, i];
                    

                }
                Console.Write(cAdd + "\t");
            }
            Console.WriteLine();

        }
        // method for for show the array from the get method
        void ShowArray()
        {
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        // method for call the methods
        public void Show3()
        {
            GetData();
            Console.WriteLine("Array is : ");
            ShowArray();
            RowAdd();
            ColAdd();
        }

    }
    class MainClass
    {
        static void Main(string[] args)
        {
            TransposeArray obj = new TransposeArray();
            Console.WriteLine("Transpose of MultiDimensional Array ");
            obj.Show();
            Console.WriteLine();
            MergeArrays mergeArrays = new MergeArrays();
            Console.WriteLine("Merging of array");
            mergeArrays.Show2();
            Console.WriteLine();
            RCAddition rcaddition = new RCAddition();
            Console.WriteLine("Row Column addition");
            rcaddition.Show3();
            Console.WriteLine();
        }
    }
}
