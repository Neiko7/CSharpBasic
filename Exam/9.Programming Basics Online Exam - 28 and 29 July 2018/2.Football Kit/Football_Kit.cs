using System;


class Football_Kit
{
    static void Main()
    {
        double priceOfTShirt = double.Parse(Console.ReadLine());
        double amountToBeReached = double.Parse(Console.ReadLine());

        double priceOfShorts = priceOfTShirt * 0.75;
        double priceOfSocks = priceOfShorts * 0.2;
        double priceOfButtons = (priceOfShorts + priceOfTShirt) * 2;
        double totalSum = (priceOfTShirt + priceOfShorts + priceOfSocks + priceOfButtons) * 0.85;

        if (totalSum >= amountToBeReached)
        {
            Console.WriteLine("Yes, he will earn the world-cup replica ball!");
            Console.WriteLine($"His sum is {totalSum:F2} lv.");
        }
        else
        {
            Console.WriteLine("No, he will not earn the world-cup replica ball.");
            Console.WriteLine($"He needs {amountToBeReached - totalSum:F2} lv. more.");
        }
    }
}

