using System;

//Logical Operators:

// AND - &&
// OR - ||
// XOP - ^
//NOT - !

class Program
{
    static void Main()
    {
        bool theTrue = true;
        bool theFalse = false;

        Console.WriteLine(theTrue && theFalse);
        Console.WriteLine(theTrue || theFalse);
        Console.WriteLine(theTrue ^ theFalse);
        Console.WriteLine(!theTrue);

        Console.WriteLine((theTrue || theFalse) && theFalse);
        Console.WriteLine((theTrue || theFalse) && (theFalse ^ theTrue));        
    }
}

