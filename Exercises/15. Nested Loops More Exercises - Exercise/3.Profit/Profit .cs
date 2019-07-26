using System;


class Profit
{
    static void Main()
    {
        int numberOfCoinsPerOneLev = int.Parse(Console.ReadLine());
        int numberOfCoinsPerTwoLeva = int.Parse(Console.ReadLine());
        int numberOfCoinsPerFiveLeva = int.Parse(Console.ReadLine());
        int sum = int.Parse(Console.ReadLine());

        for (int oneLev = 0; oneLev <= numberOfCoinsPerOneLev; oneLev++)
        {
            for (int twoLeva = 0; twoLeva <= numberOfCoinsPerTwoLeva; twoLeva++)
            {
                for (int fiveLeva = 0; fiveLeva <= numberOfCoinsPerFiveLeva; fiveLeva++)
                {
                    bool one = (oneLev * 1) + (twoLeva * 2) + (fiveLeva * 5) == sum;

                    if (one)
                    {
                        Console.WriteLine($"{oneLev} * 1 lv. + {twoLeva} * 2 lv. + {fiveLeva} * 5 lv. = {sum} lv.");
                    }
                }
            }
        }
    }
}

