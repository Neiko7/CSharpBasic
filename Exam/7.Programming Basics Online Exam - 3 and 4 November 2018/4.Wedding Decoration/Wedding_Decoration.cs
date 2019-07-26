using System;

class Wedding_Decoration
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string typeOfKind = Console.ReadLine();
        int number = 0;
        double sum = 0;
        double currentBudget = 0;
        double diff = 0;

        int counterBallons = 0;
        int counterFlowers = 0;
        int counterCandles = 0;
        int counterRibbon = 0;

        while (typeOfKind != "stop")
        {
            number = int.Parse(Console.ReadLine());

            if (typeOfKind == "balloons")
            {
                sum = number * 0.1;

                if (currentBudget >= budget)
                {
                    break;
                }
                else
                {
                    currentBudget += sum;
                    counterBallons += number;
                }
            }
            else if (typeOfKind == "flowers")
            {
                sum = number * 1.5;

                if (currentBudget >= budget)
                {
                    break;
                }
                else
                {
                    currentBudget += sum;
                    counterFlowers += number;
                }
            }
            else if (typeOfKind == "candles")
            {
                sum = number * 0.5;

                if (currentBudget >= budget)
                {
                    break;
                }
                else
                {
                    currentBudget += sum;
                    counterCandles += number;
                }
            }
            else if (typeOfKind == "ribbon")
            {
                sum = number * 2;

                if (currentBudget >= budget)
                {
                    break;
                }
                else
                {
                    currentBudget += sum;
                    counterRibbon += number;
                }
            }

            if (currentBudget >= budget)
            {
                break;
            }            
            
            typeOfKind = Console.ReadLine();
        }

        diff = Math.Abs(budget - currentBudget);

        if (currentBudget < budget)
        {
            Console.WriteLine($"Spend money: {currentBudget:F2}");
            Console.WriteLine($"Money left: {diff:F2}");
        }
        else
        {
            Console.WriteLine($"All money is spent!");
        }

        Console.WriteLine($"Purchased decoration is {counterBallons} balloons, {counterRibbon} m ribbon, {counterFlowers}" +
            $" flowers and {counterCandles} candles.");

    }
}

