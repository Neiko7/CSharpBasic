using System;

class Sea_Trip
{
    static void Main()
    {
        double moneyForFood = double.Parse(Console.ReadLine());
        double moneyForSouvenirs = double.Parse(Console.ReadLine());
        double moneyForHotel = double.Parse(Console.ReadLine());

        double moneyForGasoline = (420 / 100.00) * 7;
        moneyForGasoline = moneyForGasoline * 1.85;

        double moneyForFoodAndSouvenirs = 3 * moneyForFood + 3 * moneyForSouvenirs;

        double firstDayWithReduction = moneyForHotel * 0.90;
        double secondDayWithReduction = moneyForHotel * 0.85;
        double thirdDayWithReduction = moneyForHotel * 0.80;
        double totalSum = moneyForGasoline + moneyForFoodAndSouvenirs + firstDayWithReduction + secondDayWithReduction + thirdDayWithReduction;

        Console.WriteLine($"Money needed: {totalSum:F2}");


    }
}

