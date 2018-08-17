using System;
using System.Threading;

class Program
{
    static void Main()
    {
        string freshJuice = "Lets make fresh juice from Bananas";
        string strawberry = "Strawberry";
        int five = 500;
        float num = 325.3848485858585858F;

        Console.WriteLine("{0} and {1}.", freshJuice, strawberry);
        Console.WriteLine();
        Console.WriteLine("{0}", strawberry);
        Console.WriteLine("{0, 15}", strawberry);
        Console.WriteLine("{0, 8}", strawberry);
        Console.WriteLine("{0, 12}", strawberry);
        Console.WriteLine("{0, 10:C2}", five);
        Console.WriteLine("{0, 10:C1}", five);
        Console.WriteLine("{0, 10:C0}", five);
        Console.WriteLine("{0, 10:C5}", num);

        Thread.Sleep(3000);
    }
}

