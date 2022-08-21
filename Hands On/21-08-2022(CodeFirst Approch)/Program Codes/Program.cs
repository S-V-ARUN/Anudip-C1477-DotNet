using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcfa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SampleModel sample = new SampleModel())
            {
                Sample sam = new Sample();
                if (sam == null)
                {

                    sample.Samples.Add(sam);
                    sample.SaveChanges();
                    Console.WriteLine("TAble Created");
                }


                else
                {
                    using (SampleCFEntities Scf = new SampleCFEntities())
                    {
                        SampleTbl tbl = new SampleTbl();
                        string check;
                        do
                        {
                            Console.Write("Do u wanna add Datas : ");
                            check = Console.ReadLine();
                            check = check.ToLower();
                            if (check == "y")
                            {
                                Console.Write("Enter ID : ");
                                tbl.id = int.Parse(Console.ReadLine());
                                Console.Write("Enter Name : ");
                                tbl.Name = Console.ReadLine();
                                Console.Write("Enter age : ");
                                tbl.Age = int.Parse(Console.ReadLine());
                                Console.Write("Enter MobileNumber : ");
                                tbl.MobileNo = long.Parse(Console.ReadLine());
                                Scf.SampleTbls.Add(tbl);
                                Scf.SaveChanges();
                                Console.WriteLine("Data added Successfully");



                            }
                            else
                                break;
                        }
                        while (check == "y");

                        Console.Write("Do you view existing Data : ");
                        string q = Console.ReadLine();
                        q = q.ToLower();
                        if(q == "y")
                        {
                            var query = from v in Scf.SampleTbls select v;
                            Console.WriteLine("\n            ID            |            Name            |            Age            |            Phone_no            ");
                            foreach(var v in query)
                            {
                                Console.WriteLine("\n            {0}                         {1}                        {2}                        {3}            ", v.id,v.Name,v.Age,v.MobileNo);

                            }
                            Console.ReadLine();
                        
                        }


                    }


                }

            
            
            
            
            
            }


        }
    }
}
