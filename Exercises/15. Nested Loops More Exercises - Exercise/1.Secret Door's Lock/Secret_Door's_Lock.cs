using System;


class Secret_Doors_Lock
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        for (int firstDigit = 1; firstDigit <= a; firstDigit++)
        {
            for (int secondDigit = 1; secondDigit <= b; secondDigit++)
            {
                for (int thirdDigit = 1; thirdDigit <= c; thirdDigit++)
                {
                    bool one = firstDigit % 2 == 0 && thirdDigit % 2 == 0;
                    bool two = secondDigit == 2 || secondDigit == 3 || secondDigit == 5 || secondDigit == 7;

                    if (one && two)
                    {
                        Console.WriteLine($"{firstDigit} {secondDigit} {thirdDigit}");
                    }
                }
            }
        }
    }
}

