using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //Arrays - collection of variables of the same data type
        // Note : String are immutable - we can't make changes in the string that has already been created

        string iAmArray = "array";

        Console.WriteLine(iAmArray);
        Console.WriteLine(iAmArray[4]);

        //string[] iAmStringArray = new string[3];

        //iAmStringArray[0] = "First Item";
        //iAmStringArray[2] = "Third Item";

        //Console.WriteLine(iAmStringArray[0]);
        //Console.WriteLine(iAmStringArray[1]);
        //Console.WriteLine(iAmStringArray[2]);

        //iAmStringArray[0] = "First";
        //Console.WriteLine(iAmStringArray[0]);

        //Another way to initialize string array is:
        string[] iAmStringArray = { "abcd", "efgh", "ijkl", "mnop", "qrst", "uvwx", "yz" };

        Console.WriteLine(iAmStringArray[3]);

        Console.WriteLine(iAmStringArray.Length);
        Console.WriteLine(iAmArray.Length);

        int[] integerArray = new int[10];

        integerArray[3] = 123;

        Console.WriteLine(integerArray[3]);
        Console.WriteLine(integerArray.Length);

        //another way of initializing integer array is:
        int[] intArray = { 1, 2, 3, 4, 5 };

        Console.WriteLine(intArray[2]);
        Console.WriteLine(intArray.Length);

        Thread.Sleep(3000);
    }
}

