using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("The loop was executed {0} time!", i);
            }
            else
            {
                Console.WriteLine("The loop was executed {0} times!", i);
            }
        }

        for (int i = 10; i >= 1; i--)
        {
            if (i == 1)
            {
                Console.WriteLine("The loop was executed {0} time!", i);
            }
            else
            {
                Console.WriteLine("The loop was executed {0} times!", i);
            }
        }
    }
}

