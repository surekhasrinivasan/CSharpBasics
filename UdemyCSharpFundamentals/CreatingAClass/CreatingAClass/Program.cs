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
            Student s1 = new Student("Tom", 15, 75);
            s1.SayHello();

            Student s2 = new Student("Fred", 15, 90);
            s2.SayHello();

            Student s3 = new Student("Ted", 12, 75);
            s3.SayHello();            
        }
    }
}


