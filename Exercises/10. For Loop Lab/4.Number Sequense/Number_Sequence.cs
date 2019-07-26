using System;


class Number_Sequence
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int minNumber = int.MaxValue;
        int maxNumber = int.MinValue;

        for (int i = 1; i <= number; i++)
        {
            int command = int.Parse(Console.ReadLine());

            if (command <= minNumber)
            {
                minNumber = command;
            }
            if (command >= maxNumber)
            {
                maxNumber = command;
            }
        }

        Console.WriteLine("Max number: {0}", maxNumber);
        Console.WriteLine("Min number: {0}", minNumber);
    }
}

