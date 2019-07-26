using System;


class Numbers
{
    static void Main()
    {
        string number = Console.ReadLine();

        double firstDigit = char.GetNumericValue(number, 0);
        double secondDigit = char.GetNumericValue(number, 1);
        double thirdDigit = char.GetNumericValue(number, 2);

        double row = firstDigit + secondDigit;
        double column = firstDigit + thirdDigit;

        double num = double.Parse(number);
        

        for (int i = 1; i <=row; i++)
        {
            for (int p = 1; p <= column; p++)
            {
                if (num % 5 == 0)
                {
                    num -= firstDigit;
                    Console.Write($"{num} ");
                }
                else if (num % 3 == 0)
                {
                    num -= secondDigit;
                    Console.Write($"{num} ");
                }
                else
                {
                    num += thirdDigit;
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }

    }
}

