using System;


class Christmas_Market
{
    static void Main()
    {
        double neededMoney = double.Parse(Console.ReadLine());
        int numberOfFantasyBooks = int.Parse(Console.ReadLine());
        int numberOfHorrorBooks = int.Parse(Console.ReadLine());
        int numberOfRomanticBooks = int.Parse(Console.ReadLine());

        double amountOfSale = numberOfFantasyBooks * 14.90 + numberOfHorrorBooks * 9.80 + numberOfRomanticBooks * 4.30;
        amountOfSale *= 0.80;

        if (amountOfSale > neededMoney)
        {
            double sellers = Math.Floor((amountOfSale - neededMoney) * 0.10);
            double donationAmount = amountOfSale - sellers - neededMoney;
            double totalSum = neededMoney + donationAmount;

            Console.WriteLine($"{totalSum:F2} leva donated.");
            Console.WriteLine($"Sellers will receive {sellers} leva.");
        }
        else
        {
            double diff = neededMoney - amountOfSale;
            Console.WriteLine($"{diff:F2} money needed.");
        }

    }
}

