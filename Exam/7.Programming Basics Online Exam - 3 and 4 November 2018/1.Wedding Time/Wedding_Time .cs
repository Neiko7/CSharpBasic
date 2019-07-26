using System;


class Wedding_Time 
{
    static void Main()
    {
        double priceOfWhiskey = double.Parse(Console.ReadLine());
        double amountOfWater = double.Parse(Console.ReadLine());
        double amountOfWine = double.Parse(Console.ReadLine());
        double amountOfChampagne = double.Parse(Console.ReadLine());
        double amountOfWhiskey = double.Parse(Console.ReadLine());

        double priceOfChampagne = priceOfWhiskey * 0.50;
        double priceOfWine = priceOfChampagne * 0.40;
        double priceOfWater = priceOfChampagne * 0.10;

        double sumOfWater = amountOfWater * priceOfWater;
        double sumOfWine = amountOfWine * priceOfWine;
        double sumOfChampagne = amountOfChampagne * priceOfChampagne;
        double sumOfWhiskey = amountOfWhiskey * priceOfWhiskey;

        double totalSum = sumOfWater + sumOfWine + sumOfChampagne + sumOfWhiskey;

        Console.WriteLine($"{totalSum:F2}");

    }
}

