using System;


class Sum_Of_Two_Numbers
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int finishNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int firstDigit = startNumber; firstDigit <= finishNumber; firstDigit++)
        {
            for (int secondDigit = startNumber; secondDigit <= finishNumber; secondDigit++)
            {
                counter++;
                bool one = firstDigit + secondDigit == magicNumber;

                if (one)
                {
                    Console.WriteLine($"Combination N:{counter} ({firstDigit} + {secondDigit} = {magicNumber})");
                    return;
                }
            }
        }
        
        Console.WriteLine($"{ counter} combinations - neither equals {magicNumber}");

    }
}

