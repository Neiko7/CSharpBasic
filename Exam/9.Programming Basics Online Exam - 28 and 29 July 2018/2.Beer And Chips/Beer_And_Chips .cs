using System;


class Beer_And_Chips
{
    static void Main()
    {
        string nameOfFen = Console.ReadLine();
        double budget = double.Parse(Console.ReadLine());
        int numberOfBottleBeer = int.Parse(Console.ReadLine());
        int numberOfPacketSnack = int.Parse(Console.ReadLine());

        double totalPriceOfBeer = 1.20 * numberOfBottleBeer;
        double priceOfPacketSnack = totalPriceOfBeer * 0.45;
        double totalPriceOfPacketSnack = Math.Ceiling(priceOfPacketSnack * numberOfPacketSnack);
        double totalSum = totalPriceOfBeer + totalPriceOfPacketSnack;

        double diff = Math.Abs(budget - totalSum);

        if (budget >= totalSum)
        {
            Console.WriteLine($"{nameOfFen} bought a snack and has {diff:F2} leva left.");
        }
        else
        {
            Console.WriteLine($"{nameOfFen} needs {diff:F2} more leva!");
        }

    }
}

