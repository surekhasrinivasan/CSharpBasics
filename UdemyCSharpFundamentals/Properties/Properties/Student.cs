using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        private string name;
        private int age;
        private double finalGrade;
        //Auto-Implemented Property
        public string LastName { get; private set; }

        public Student(string name, string lastName, int age, double finalGrade)
        {
            this.name = name;
            this.LastName = lastName;
            this.age = age;
            this.finalGrade = finalGrade;
        }


        //constructor overloading 
        public Student(string name, string lastName, int age) : this(name, lastName, age, 0)
        {
            
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}", name);
        }

        //Properties are specific way of C-Sharp doing get and set functions. A property at compile time gets converted to a 
        //function but it allows us to basically do that syntax of using the assignment operator instead of calling that function.
        
        //Name property 

        public string Name
        {
            get
            {
                if (age >= 18)
                {
                    return name;
                }
                else
                {
                    return "The student is too young";
                }
            }
            //As the property has no parameters so we use special keyword called value to get the value of what the using trying to set
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }

        //public string GetName()
        //{
        //    if (age >= 18)
        //    {
        //        return name;
        //    }
        //    else
        //    {
        //        return "The student is too young";
        //    }
        //}

        //public void SetName(string newName)
        //{
        //    if (newName != "")
        //    {
        //        name = newName;
        //    }
        //}

        //Age property
        public int Age
        {
            get
            {
                if (age >= 18)
                {
                    return age;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (value != 0)
                {
                    age = value;
                }
            }
        }

        //public int GetAge()
        //{
        //    if (age >= 18)
        //    {
        //        return age;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}

        //public void SetAge(int newAge)
        //{
        //    if (newAge != 0)
        //    {
        //        age = newAge;
        //    }
        //}

        //FinalGrade property
        public double FinalGrade
        {
            get
            {
                return finalGrade;
            }
            set
            {
                if (value < 65)
                {
                    value = 65;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                finalGrade = value;
            }
        }
        
        //public double GetFinalGrade()
        //{
        //    return finalGrade;
        //}

        //public void SetFinalGrade(double newFinalGrade)
        //{
        //    if (newFinalGrade < 65)
        //    {
        //        newFinalGrade = 65;
        //    }
        //    else if (newFinalGrade > 100)
        //    {
        //        newFinalGrade = 100;
        //    }
        //    finalGrade = newFinalGrade;
        //}
    }
}
