using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //new - means instantiating the class
            Student s1 = new Student("Tom", 19, 75);
            //s1.SayHello();
            Console.WriteLine(s1.GetName());

            //Student s2 = new Student("Fred", 15, 90);
            //s2.SayHello();

            //Student s3 = new Student("Ted", 12, 75);
            //s3.SayHello();

            //Student s4 = new Student("Frank", 10);
            //s4.SayHello();
        }
    }
}


