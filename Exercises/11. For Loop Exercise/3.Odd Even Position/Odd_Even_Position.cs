using System;


class Odd_Even_Position
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double oddMax = double.MinValue;
        double oddMin = double.MaxValue;
        double evenMax = double.MinValue;
        double evenMin = double.MaxValue;

        double oddSum = 0;
        double evenSum = 0;

        for (int i = 1; i <= n; i++)
        {
            double num = double.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                if (num > evenMax)
                {
                    evenMax = num;
                }
                if (num < evenMin)
                {
                    evenMin = num;
                }

                evenSum += num;
            }
            else
            {
                if (num > oddMax)
                {
                    oddMax = num;
                }
                if (num < oddMin)
                {
                    oddMin = num;
                }

                oddSum += num;
            }
        }

        Console.WriteLine("OddSum={0:F2},", oddSum);

        if (oddMin == double.MaxValue)
        {
            Console.WriteLine("OddMin=No,");
        }
        else
        {
            Console.WriteLine("OddMin={0:F2},",oddMin);
        }

        if (oddMax == double.MinValue)
        {
            Console.WriteLine("OddMax=No,");
        }
        else
        {
            Console.WriteLine("OddMax={0:F2},", oddMax);
        }

        Console.WriteLine("EvenSum={0:F2},", evenSum);

        if (evenMax == double.MinValue)
        {
            Console.WriteLine("EvenMin=No,");
        }
        else
        {
            Console.WriteLine("EvenMin={0:F2},", evenMin);
        }

        if (evenMax == double.MinValue)
        {
            Console.WriteLine("EvenMax=No");
        }
        else
        {
            Console.WriteLine("EvenMax={0:F2}", evenMax);
        }
    }
}

