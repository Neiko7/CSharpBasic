using System;


class AlcoholMarket
{
    static void Main()
    {
        double whiskeyPrice = double.Parse(Console.ReadLine());
        double beerQuantity = double.Parse(Console.ReadLine());
        double wineQuantity = double.Parse(Console.ReadLine());
        double rakiaQuantity = double.Parse(Console.ReadLine());
        double whiskeyQuantity = double.Parse(Console.ReadLine());

        double rakiaPrice = (0.5 * whiskeyPrice);
        double winePrice = rakiaPrice - (0.4 * rakiaPrice);
        double beerPrice = rakiaPrice - (0.8 * rakiaPrice);

        double rakiaSum = rakiaQuantity * rakiaPrice;
        double wineSum = wineQuantity * winePrice;
        double beerSum = beerQuantity * beerPrice;
        double whiskeySum = whiskeyQuantity * whiskeyPrice;

        double totalSum = rakiaSum + wineSum + beerSum + whiskeySum;

        Console.WriteLine($"{totalSum:F2}");
    }
}

