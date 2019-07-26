using System;


class Godzilla_Vs_Kong 
{
    static void Main()
    {
        double movieBudget = double.Parse(Console.ReadLine());
        int numberOfStatistics = int.Parse(Console.ReadLine());
        double priceOfClothing = double.Parse(Console.ReadLine());

        double sumForDecor = movieBudget * 0.10;
        double totalPriceOfClothing = numberOfStatistics * priceOfClothing;

        if (numberOfStatistics > 150)
        {
            totalPriceOfClothing *= 0.90;
        }
        
        double totalSumForMovie = sumForDecor + totalPriceOfClothing;
        double diff = Math.Abs(movieBudget - totalSumForMovie);

        if (totalSumForMovie <= movieBudget)
        {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {diff:F2} leva left.");
        }
        else
        {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {diff:F2} leva more.");
        }
    }
}

