using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample1
{
    class Program
    {
        /**  Write a program for a package delivery service. The program
            *contains an array that holds the ten zip codes to which the
            *company delivers packages. Prompt a user to enter a zip
            *code and display a message indicating whether the zip code
            *is one to which the company delivers.
            * */

        static void Main(string[] args)
        {
            string[] zipCodes = {"10000", "11567", "445566", "778855", "334455", "667788",
                                "112233", "445522", "556677", "667789" };

            Console.WriteLine("Enter the zip code: ");
            string code = Console.ReadLine();

            bool found = false;

            for(int i = 0; i < zipCodes.Length; i++)
            {
                if(code == zipCodes[i])
                {
                    found = true;
                    break;
                }
            }
            if(found == true)
            {
                Console.WriteLine("We do ship to this zip code");
            }
            else
            {
                Console.WriteLine("We do NOT ship to this zip code");
            }
        }
    }
}
