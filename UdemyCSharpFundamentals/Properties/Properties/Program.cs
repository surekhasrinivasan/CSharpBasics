﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        //A property is just a shorthand for get and set functions that is specific to c-sharp. 
        //It makes it a little easier for the user of your class to set the data ad get the data 
        //because they can treat it as a normal variable. 

        static void Main(string[] args)
        {
            //new - means instantiating the class
            Student s1 = new Student("Tom", "Bob", 19, 75);
            //s1.SetName("");
            //property is just a syntax, it gets coverted to a function call at the end.
            s1.Name = "";
            // Console.WriteLine(s1.GetName());
            Console.WriteLine(s1.Name);

            //s1.SetFinalGrade(105);
            //Console.WriteLine(s1.GetFinalGrade());
            s1.FinalGrade = 105;
            Console.WriteLine(s1.FinalGrade);
            Console.WriteLine(s1.LastName);
        }
    }
}
