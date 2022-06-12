using System;
class RangeException : Exception
{
    public RangeException(string mss) : base(mss)
    {

    }
}
namespace SquareRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            try
            {
                if((num < 10 )|| (num > 50))
                {
                    throw new RangeException("Number is out of Range");
                }
                else
                {
                    int sqr = num * num;
                    Console.WriteLine("Square of {0} is {1}",num,sqr);
                }
            }
            catch(RangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program runs successfully");
            }
        }
    }
}
