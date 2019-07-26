using System;

class Easter_Bake
{
    static void Main()
    {
        int numberOFEasterBread = int.Parse(Console.ReadLine());

        int quantityOfSugarConsumed = 0;
        int quantityOfFlourConsumed = 0;
        double totalSugar = 0;
        double totalFlour = 0;
        int maxSugar = int.MinValue;
        int maxFlour = int.MinValue;

        for (int i = 1; i <= numberOFEasterBread; i++)
        {
            quantityOfSugarConsumed = int.Parse(Console.ReadLine());
            quantityOfFlourConsumed = int.Parse(Console.ReadLine());

            totalSugar += quantityOfSugarConsumed;
            totalFlour += quantityOfFlourConsumed;

            if (quantityOfSugarConsumed > maxSugar)
            {
                maxSugar = quantityOfSugarConsumed;
            }

            if (quantityOfFlourConsumed > maxFlour)
            {
                maxFlour = quantityOfFlourConsumed;
            }
        }

        totalSugar = Math.Ceiling(totalSugar / 950);
        totalFlour = Math.Ceiling(totalFlour / 750);

        Console.WriteLine($"Sugar: {totalSugar}");
        Console.WriteLine($"Flour: {totalFlour}");
        Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
    }
}
