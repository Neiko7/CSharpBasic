using System;


class Multiply_Table
{
    static void Main()
    {
        string number = Console.ReadLine();

        double firstDigit = char.GetNumericValue(number, 0);
        double secondDigit = char.GetNumericValue(number, 1);
        double thirdDigit = char.GetNumericValue(number, 2);

        for (int i = 1; i <= thirdDigit; i++)
        {
            for (int y = 1; y <= secondDigit; y++)
            {
                for (int t = 1; t <= firstDigit; t++)
                {
                    Console.WriteLine($"{i} * {y} * {t} = {i* y * t};");
                }
            }

        }

    }
}
