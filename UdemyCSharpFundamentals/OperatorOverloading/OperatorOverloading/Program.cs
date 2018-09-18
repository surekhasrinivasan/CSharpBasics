using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        //Operator Overloading
        static void Main(string[] args)
        {
            BankAccount bank1 = new BankAccount(50, "Bob");
            BankAccount bank2 = new BankAccount(150, "Fred");

            BankAccount bank3 = bank1 + bank2;

            Console.WriteLine(bank3.Money);
            Console.WriteLine(bank3.Owner);
        }
    }
}
