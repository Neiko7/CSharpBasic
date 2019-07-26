using System;

class Puppy_Care
{
    static void Main()
    {
        int food = int.Parse(Console.ReadLine()) * 1000;
        string command = Console.ReadLine();
        int purchasedFood = 0;
        int totalFood = 0;

        while (command != "Adopted")
        {
            purchasedFood = int.Parse(command);

            totalFood += purchasedFood;

            command = Console.ReadLine();
        }

        int diff = Math.Abs(food - totalFood);

        if (food >= totalFood)
        {
            Console.WriteLine($"Food is enough! Leftovers: {diff} grams.");
        }
        else
        {
            Console.WriteLine($"Food is not enough. You need {diff} grams more.");
        }
    }
}

