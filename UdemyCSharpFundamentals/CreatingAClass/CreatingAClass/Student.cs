using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAClass
{
    class Student
    {
        private string name;
        private int age;
        private double finalGrade;

        /*Constructors - A constructor is a Method. The job of the constructor is to prepare this instance of this class 
         * to be ready. So the constructors are basically parameters to the class.
         * Constructor is a special type of function because of two reasons the constructor has no 
         * return type and the constructor has always the name of the class.
         **/

        public Student(string name, int age, double finalGrade)
        {
            this.name = name;
            this.age = age;
            this.finalGrade = finalGrade;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }
    }
}
