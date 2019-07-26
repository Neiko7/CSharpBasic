using System;


class Odd_Even_Sum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumOdd = 0;
        int sumEven = 0;

        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i % 2 != 0)
            {
                sumOdd += number;
            }
            else
            {
                sumEven += number;
            }

        }

        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", sumOdd);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", Math.Abs(sumOdd - sumEven));
        }
    }
}
