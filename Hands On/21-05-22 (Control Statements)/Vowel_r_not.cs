// 5.) write a program to check giver character is vowel or not


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project1

{
  class Vowel_r_not
    {
        static void Main(string[] args)

        {
            char wrd1;
            
            Console.Write("Enter a number - ");
            wrd1 = char.Parse(Console.ReadLine());
            
            if (wrd1=='a' || wrd1=='e' || wrd1 == 'i'|| wrd1 == 'o' || wrd1 == 'u' 
                || wrd1 == 'A' || wrd1 == 'E' || wrd1 == 'I' || wrd1 == 'O' || wrd1 == 'U')

                Console.WriteLine("{0} is a vowel",wrd1);
            else
                Console.WriteLine("{0} is not a vowel", wrd1);
            
        }
    }
}