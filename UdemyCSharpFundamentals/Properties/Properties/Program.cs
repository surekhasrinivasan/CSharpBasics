using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //new - means instantiating the class
            Student s1 = new Student("Tom", 19, 75);
            //s1.SetName("");
            //property is just a syntax, it gets coverted to a function call at the end.
            s1.Name = "Bob";
            // Console.WriteLine(s1.GetName());
            Console.WriteLine(s1.Name);
            s1.SetFinalGrade(105);
            Console.WriteLine(s1.GetFinalGrade());

        }
    }
}
