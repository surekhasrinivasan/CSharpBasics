using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRefVal
{
    class Program
    {
        //Pass by Reference vs. pass by Value

        static void Main(string[] args)
        {
            //Pass by Value
            int student1Grade = 75;
            Console.WriteLine("Students grade before extra credit {0}", student1Grade);
            GiveExtraCredit(student1Grade);
            Console.WriteLine("Students grade AFTER extra credit {0}", student1Grade);

            //Pass by Reference
            int[] grades = new int[1];
            grades[0] = 75;
            Console.WriteLine("Student array grade before extra credit {0}", grades[0]);
            GiveExtraCreditArray(grades);
            Console.WriteLine("Student array grade AFTER extra credit {0}", grades[0]);
        }

        public static void GiveExtraCredit(int studentsGrade)
        {
            studentsGrade += 3;
            Console.WriteLine("Students grade after extra credit inside function {0}", studentsGrade);
        }

        public static void GiveExtraCreditArray(int[] grades)
        {
            grades[0] += 3;
        }
    }
}
