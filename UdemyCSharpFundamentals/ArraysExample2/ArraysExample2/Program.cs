using System;

namespace ArraysExample2
{
    class Program
    {
        static void Main()
        {
            /*
             * 
             *  Write a program that allows a teacher to enter in an amount of students. For each
             *  student ask the teacher to enter in their name and final score for the class. When
             *  the teacher is done entering the data, print the highest grade in the class, and the average grade
             *  for the class.
             * */

            Console.WriteLine("Enter the amount of students in your class");
            int amountOfStudents = int.Parse(Console.ReadLine());

            double averageGrade = 0;
            double highestGrade = 0;
            
            string[] studentNames = new string[amountOfStudents];
            double[] grades = new double[amountOfStudents];

            for (int i = 0; i < amountOfStudents; i++)
            {
                Console.WriteLine("Enter student #{0} name", i + 1);
                string name = Console.ReadLine();
                Console.WriteLine("Enter student #{0} grade", i + 1);
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                averageGrade += grade;                
            }

            //all the below 3 syntax mean the same
            //double average = averageGrade / amountOfStudents;
            //averageGrade = averageGrade / amountOfStudents;
            averageGrade /= amountOfStudents;
            Console.WriteLine("The average grade of the class is {0}", averageGrade);
        }
    }
}
