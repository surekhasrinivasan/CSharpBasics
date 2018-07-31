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
                Console.WriteLine("Enter Age: ");
                Age = Convert.ToInt16(Console.ReadLine());

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
