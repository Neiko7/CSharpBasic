using System;


class Car_Number
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int finishNumber = int.Parse(Console.ReadLine());

        for (int firstDigit = startNumber; firstDigit <= finishNumber; firstDigit++)
        {
            for (int secondDigit = startNumber; secondDigit <= finishNumber; secondDigit++)
            {
                for (int thirdDigit = startNumber; thirdDigit <= finishNumber; thirdDigit++)
                {
                    for (int fourthDigit = startNumber; fourthDigit <= finishNumber; fourthDigit++)
                    {
                        bool one = firstDigit % 2 == 0 && fourthDigit % 2 != 0 || firstDigit % 2 != 0 && fourthDigit % 2 == 0;
                        bool two = firstDigit > fourthDigit;
                        bool three = (secondDigit + thirdDigit) % 2 == 0;

                        if (one && two && three)
                        {
                            Console.Write($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit} ");
                        }
                    }
                }
            }
        }

    }
}

