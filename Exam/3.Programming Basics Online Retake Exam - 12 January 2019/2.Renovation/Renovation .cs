using System;


class Renovation
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double widthOfFloor = double.Parse(Console.ReadLine());
        double lengthOfFloor = double.Parse(Console.ReadLine());
        double sideOfTriangle = double.Parse(Console.ReadLine());
        double heightOfTriangle = double.Parse(Console.ReadLine());
        double priceOfOneTile = double.Parse(Console.ReadLine());
        double sumForMaster = double.Parse(Console.ReadLine());

        double floorArea = widthOfFloor * lengthOfFloor;
        double areaOfTile = sideOfTriangle * heightOfTriangle / 2;
        double requiredTiles = Math.Ceiling(floorArea / areaOfTile) + 5;
        double totalSum = requiredTiles * priceOfOneTile + sumForMaster;

        double diff = Math.Abs(budget - totalSum);

        if (totalSum <= budget)
        {
            Console.WriteLine($"{diff:F2} lv left.");
        }
        else
        {
            Console.WriteLine($"You'll need {diff:F2} lv more.");
        }

    }
}

