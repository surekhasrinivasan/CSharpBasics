using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Name = "";
                int Age = 0;

                Console.WriteLine("Enter Name: ");
                Name = Console.ReadLine();
                if(Name.Length == 0)
                {
                    Console.WriteLine("Name is required");
                    Console.Read();
                    return;
                }

                Console.WriteLine("Enter Age: ");
                Age = Convert.ToInt16(Console.ReadLine());
                if(Age > 100)
                {
                    Console.WriteLine("Invalid Age");
                    Console.Read();
                    return;
                }

                Console.WriteLine("Hello " + Name + " " + Age);
                Console.Read();               
            }
            catch(Exception e)
            {
                Console.WriteLine("Please try ....invalid data");
            }
        }
    }
}
