
using System;

class BalanceCheck : Exception
{
    public BalanceCheck(String mess) : base (mess)
    {

    }
    

}


namespace Test
{
    class BankingSystem
    {

        int balance;
        public BankingSystem(int balance)
        {
           this .balance = balance;
        }

        int withDraw()
        {
            Console.Write("Enter amount to withdraw : ");
            int amo = int.Parse(Console.ReadLine());
            balance = balance-amo;
            return balance;
        }
        int deposit()
        {
            Console.Write("Enter amount to deposit : ");
            int amo = int.Parse(Console.ReadLine());
            balance = balance + amo;
            return balance;

        }
        
        void iCompute()

        {
            char iCheck = 'y';
            do
            {
                Console.WriteLine("Enter 1 for withdraw : ");
                Console.WriteLine("Enter 2 for Deposite : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            try
                            {
                                if (balance < 1000)
                                {
                                    throw new BalanceCheck("Minimum Balance Reached no more withdraw ");
                                }
                                else
                                {
                                    int newbal1 = withDraw();
                                    Console.WriteLine("Withdraw Successfull New Balance is {0}", newbal1);
                                }
                            }
                            catch (BalanceCheck Obj1)
                            {
                                Console.WriteLine(Obj1.Message);
                            }
                            break;

                        }
                    case 2:
                        {
                            int newbal2 = deposit();
                            Console.WriteLine("Deposit Successfull New Balance is {0}", newbal2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Thanks for Visiting");
                            break;
                        }
                }
                Console.Write("Enter y to Continue n to exit : ");
                iCheck = Char.Parse(Console.ReadLine());

            }
            while (iCheck=='y');
            {

            }
        }

        public void doSomething()
        {
            iCompute();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            BankingSystem Obj1 = new BankingSystem(100);
            Obj1.doSomething();
         
            
            
        }
    }
}