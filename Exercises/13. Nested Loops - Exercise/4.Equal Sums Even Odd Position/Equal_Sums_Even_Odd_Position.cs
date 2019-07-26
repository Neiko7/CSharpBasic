using System;


class Equal_Sums_Even_Odd_Position
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());

        for (int i = numberOne; i <= numberTwo; i++)
        {
            int currentNumber = i;

            int sixthDigit = currentNumber % 10;

            currentNumber /= 10;
            int fifthDigit = currentNumber % 10;

            currentNumber /= 10;
            int fourthDigit = currentNumber % 10;

            currentNumber /= 10;
            int thirdDigit = currentNumber % 10;

            currentNumber /= 10;
            int secondDigit = currentNumber % 10;

            int firstDigit = currentNumber / 10;

            if (firstDigit + thirdDigit + fifthDigit == secondDigit + fourthDigit + sixthDigit)
            {
                Console.Write($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit}{fifthDigit}{sixthDigit} ");
            }
        }
    }
}

