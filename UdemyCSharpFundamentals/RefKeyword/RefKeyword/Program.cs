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
            GiveExtraCredit(studentGrade);
            Console.WriteLine(studentGrade);
        }

        public static void GiveExtraCredit(int studentGrade)
        {
            studentGrade += 3;
        }
}
