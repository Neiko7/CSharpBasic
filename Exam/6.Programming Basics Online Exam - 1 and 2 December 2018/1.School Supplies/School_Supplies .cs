using System;


class Program
{
    static void Main()
    {
        int numberOfPackagesOfChemicals = int.Parse(Console.ReadLine());
        int numberOfPackagesOfMarkers = int.Parse(Console.ReadLine());
        double preparation = double.Parse(Console.ReadLine());
        int percentageReduction = int.Parse(Console.ReadLine());

        double sumChemicals = numberOfPackagesOfChemicals * 5.80;
        double sumMarkers = numberOfPackagesOfMarkers * 7.20;
        double sumPreparation = preparation * 1.20;

        double sum = sumChemicals + sumMarkers + sumPreparation;
        double totalSum = (sum - (sum * percentageReduction) / 100);
        Console.WriteLine($"{totalSum:F3}");

    }
}

