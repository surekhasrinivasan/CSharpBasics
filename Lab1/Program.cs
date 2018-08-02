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
            Console.WriteLine("Enter how many records?");
            int numRecord = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < numRecord; i++)
            {
                try
                {
                    //string Name = "";
                    //int Age = 0;

                    //Console.WriteLine("Enter Name: ");
                    //Name = Console.ReadLine();
                    //if (Name.Length == 0)
                    //{
                    //    Console.WriteLine("Name is required");
                    //    Console.Read();
                    //    return;
                    //}

                    //Console.WriteLine("Enter Age: ");
                    //Age = Convert.ToInt16(Console.ReadLine());
                    //if (Age > 100)
                    //{
                    //    Console.WriteLine("Invalid Age");
                    //    Console.Read();
                    //    return;
                    //}
                    //Console.WriteLine("Hello " + Name + " " + Age);
                    //Console.Read();

                    Person obj = new Person();
                    Console.WriteLine("Enter Name: ");
                    obj.Name = Console.ReadLine();
                    Console.WriteLine("Enter Age: ");
                    obj.Age = Convert.ToInt16(Console.ReadLine());

                    if (obj.Valid())
                    {
                        Console.WriteLine("Name " + obj.Name + "Age " + obj.Age);
                    }
                    else
                    {
                        Console.WriteLine("Please try ....invalid data");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please try ....invalid data");
                }
                Console.ReadLine();
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }

        public bool Valid()
        {
            if (Name.Length == 0)
            {
                return false;
            }
            if(Age > 100)
            {
                return false;
            }
            return true;
        }
    }
}
