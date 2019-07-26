using System;


class Equal_Sums_Left_Right_Position
{
    static void Main()
    {
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());

        for (int i = numberOne;  i <= numberTwo; i++)
        {
            int currentNum = i;

            int fifthDigit = currentNum % 10;

            currentNum /= 10;
            int fourthDigit = currentNum % 10;

            currentNum /= 10;
            int thirdDigit = currentNum % 10;

            currentNum /= 10;
            int secondDigit = currentNum % 10;

            int firstDigit = currentNum / 10;

            if (firstDigit + secondDigit == fourthDigit + fifthDigit)
            {
                Console.Write(i + " ");
            }
            else if (firstDigit + secondDigit + thirdDigit == fourthDigit + fifthDigit)
            {
                Console.Write(i + " ");
            }
            else if (firstDigit + secondDigit == thirdDigit + fourthDigit + fifthDigit)
            {
                Console.Write(i + " ");
            }
        }
    }
}

