using System;

class Computer_Firm
{
    static void Main()
    {
        double n = int.Parse(Console.ReadLine());

        int possibleSalesAndRating = 0;
        double rating = 0;
        double possibleTotalSales = 0;

        double totalRating = 0;
        double totalSales = 0;


        for (int i = 1; i <= n; i++)
        {
            possibleSalesAndRating = int.Parse(Console.ReadLine());

            rating = possibleSalesAndRating % 10;
            possibleTotalSales = possibleSalesAndRating / 10;

            if (rating == 3)
            {
                totalSales += possibleTotalSales * 0.50;
            }
            else if (rating == 4)
            {
                totalSales += possibleTotalSales * 0.70;
            }
            else if (rating == 5)
            {
                totalSales += possibleTotalSales * 0.85;
            }
            else if (rating == 6)
            {
                totalSales += possibleTotalSales;
            }

            totalRating += rating;
        }
        Console.WriteLine($"{totalSales:F2}");
        Console.WriteLine($"{(totalRating / n):F2}");

    }
}

