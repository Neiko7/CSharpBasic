using System;

class Maiden_Party
{
    static void Main()
    {
        double priceOfMaidenParty = double.Parse(Console.ReadLine());
        int numberOfLoveMessages = int.Parse(Console.ReadLine());
        int numberOfWaxRoses = int.Parse(Console.ReadLine());
        int numberOfKeyRings = int.Parse(Console.ReadLine());
        int numberOfCartoons = int.Parse(Console.ReadLine());
        int numberOfLuckSurprises = int.Parse(Console.ReadLine());

        double finalPrice = 0;
        double costOfHosting = 0;
        double profit = 0;
        double diff = 0;

        double totamSum = numberOfLoveMessages * 0.60 + numberOfWaxRoses * 7.20 + numberOfKeyRings * 3.60 +
            numberOfCartoons * 18.20 + numberOfLuckSurprises * 22;

        int numberOfItems = numberOfLoveMessages + numberOfWaxRoses + numberOfKeyRings + numberOfCartoons + numberOfLuckSurprises;

        if (numberOfItems > 25)
        {
            finalPrice = totamSum * 0.65;
            costOfHosting = finalPrice * 0.10;
            profit = finalPrice - costOfHosting;
        }
        else
        {
            costOfHosting = totamSum * 0.10;
            profit = totamSum - costOfHosting;
        }

        diff = Math.Abs(priceOfMaidenParty - profit);

        if (profit >= priceOfMaidenParty)
        {
            Console.WriteLine($"Yes! {diff:F2} lv left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! {diff:F2} lv needed.");
        }
    }
}

