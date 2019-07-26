using System;

class Going_Home
{
    static void Main()
    {
        double distanceInKilometers = int.Parse(Console.ReadLine());
        double petrolConsumptionPer100Kilometers = int.Parse(Console.ReadLine());
        double priceOfGasolinePerLiter = double.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());

        double consumptionOfTheCar = (distanceInKilometers * petrolConsumptionPer100Kilometers) / 100;
        double totalCost = consumptionOfTheCar * priceOfGasolinePerLiter;

        double diff = Math.Abs(totalCost - budget);

        if (totalCost <= budget)
        {
            Console.WriteLine($"You can go home. {diff:F2} money left.");
        }
        else
        {
            budget /= 5;
            Console.WriteLine($"Sorry, you cannot go home. Each will receive {budget:F2} money.");
        }
    }
}

