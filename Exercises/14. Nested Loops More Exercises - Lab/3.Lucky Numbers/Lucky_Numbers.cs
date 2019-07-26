using System;

class Lucky_Numbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int firstDigit = 1; firstDigit <= 9; firstDigit++)
        {
            for (int secondDigit = 1; secondDigit <= 9; secondDigit++)
            {
                for (int thirdDigit = 1; thirdDigit <= 9; thirdDigit++)
                {
                    for (int fourthDigit = 1; fourthDigit <= 9; fourthDigit++)
                    {
                        int firstSum = firstDigit + secondDigit;
                        int secondSum = thirdDigit + fourthDigit;

                        if (firstSum == secondSum && number % firstSum == 0)
                        {
                            Console.Write($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit} ");
                        }
                    }
                }
            }
        }
    }
}

