using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAClass
{
    class Student
    {
        //The idea of oop always enforces that you should make your data private that allows us to protect our class. 
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

        
        //constructor overloading 
        public Student(string name, int age) : this(name,age, 0)
        {
            //code duplication so we can use constructor initializer (i.e., call another constructor in this constructor)
            //this.name = name;
            //this.age = age;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }

        public string GetName()
        {
            if(age >= 18)
            {
                return name;
            }
            else
            {
                return "The student is too young";
            }
        }

        public void SetName(string newName)
        {
            if(newName != "")
            {
                name = newName;
            }
        }

        public int GetAge()
        {
            if(age >= 18)
            {
                return age;
            }
            else
            {
                return -1;
            }
        }

        public void SetAge(int newAge)
        {
            if(newAge != 0)
            {
                age = newAge;
            }
        }

        public double GetFinalGrade()
        {
            return finalGrade;
        }

        public void SetFinalGrade(double newFinalGrade)
        {
            if(newFinalGrade < 65)
            {
                newFinalGrade = 65;
            }
            else if(newFinalGrade > 100)
            {
                newFinalGrade = 100;
            }
            finalGrade = newFinalGrade;
        }
    }
}
