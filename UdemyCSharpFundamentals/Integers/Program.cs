using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //int type hold 32 bit numbers
        
        int someInteger = 5;

        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);
        
        //unsigned int 
        uint someUInteger = 1;

        Console.WriteLine(uint.MinValue);
        Console.WriteLine(uint.MaxValue);
        //Console.WriteLine(Math.Pow(2, 32));

        //Byte type holds 8 bit numbers  
        byte someByte = 255; // from 0 to 255

        sbyte negativeByte = -1; //signed byte -128 to 127 

        Console.WriteLine(byte.MinValue);
        Console.WriteLine(byte.MaxValue);
        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine(sbyte.MaxValue);

        //long type holds 64 bit numbers 

        long someVeryLongNumber = 34556758675455;

        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);

        //unsigned long 
        ulong noNegativeLongNumbers = 0;

        Console.WriteLine(ulong.MinValue);
        Console.WriteLine(ulong.MaxValue);

        Thread.Sleep(3000);
    }
}

