using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Exception_Handling
{
    class AgeException : Exception
    {
        public AgeException(string mess) : base(mess)
        {

 

        }
        public static void AgeCheck(int age)
        {
            if (age < 18)
            {
                throw new AgeException("Minors not Allowed ");
            }
            if (age > 60)
            {
                throw new AgeException("Senior Citizens not Allowed");
            }

 

        }
    }
    public class pubentry
    {
        string name;
        int age, count;
        public pubentry(string name, int age, int count)
        {
            this.name = name;
            this.age = age;
            this.count = count;
        }
        public void generatebill()
        {
            try
            {
                AgeException.AgeCheck(age);
                Console.WriteLine("Your Bill : \n");
                Console.WriteLine("Name : {0} ",name);
                Console.WriteLine("Your Bill Amount : {0}", count * 20000);
                Console.WriteLine("Thanks for Booking ;)");

 


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("See you soon :)");
            }

 

        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter Your Name :");
                string name = Console.ReadLine();
                Console.Write("Enter Your Age :");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Total no of persons :");
                int count = int.Parse(Console.ReadLine());
                pubentry p = new pubentry(name,age,count);
                p.generatebill();
                Console.ReadLine();

 


            }
        }
    }
}
