using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyword
{
    class Program
    {
        //Out Keyword 

        static void Main(string[] args)
        {
            //ref keyword requires initial value whereas while out keyword requires to assign value inside 
            //the function(it is still pass by reference), out keyword is used to send in back many return values 

            //    int studentGrade;
            //    GiveExtraCredit(out studentGrade);
            //    Console.WriteLine(studentGrade);
            //}

            //public static void GiveExtraCredit(out int studenGrade)
            //{
            //    studenGrade = 0;
            //    studenGrade += 3;
            //}

            //Adding program with output parameter

            int add;
            int mult;
            AddAndMult(22, 10, out add, out mult);
            Console.WriteLine(add);
            Console.WriteLine(mult);
        }
            
        public static void AddAndMult(int a,int b, out int added, out int mult)
        {
            added = a + b;
            mult = a * b;
        }
    }
}
