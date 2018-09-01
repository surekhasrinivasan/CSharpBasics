using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKeyword
{
    class Program
    {
        //Ref Keyword

        static void Main(string[] args)
        {
            int studentGrade = 75;
            GiveExtraCredit(ref studentGrade);
            Console.WriteLine(studentGrade);
        }
        
        //forcing pass by value to get pass by reference by adding ref keyword 
        public static void GiveExtraCredit(ref int studentGrade)
        {
            studentGrade += 3;
        }
    }
}
