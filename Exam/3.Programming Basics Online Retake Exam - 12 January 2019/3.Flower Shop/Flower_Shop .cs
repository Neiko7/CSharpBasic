using System;


class Flower_Shop 
{
    static void Main()
    {
        int numOfChrysanthemums = int.Parse(Console.ReadLine());
        int numOfRoses = int.Parse(Console.ReadLine());
        int numOfTulips = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        char feastDay = char.Parse(Console.ReadLine());

        double sumFlowers = 0;
        double totalFlowers = numOfChrysanthemums + numOfRoses + numOfTulips;

        
        if (season == "Spring" || season == "Summer")
        {
            sumFlowers = numOfChrysanthemums * 2.00 + numOfRoses * 4.10 + numOfTulips * 2.50;
        }
        else if (season == "Autumn" || season == "Winter")
        {
            sumFlowers = numOfChrysanthemums * 3.75 + numOfRoses * 4.50 + numOfTulips * 4.15;
        }

        if (feastDay == 'Y')
        {
            sumFlowers *= 1.15;
        }

        if (season == "Spring" && numOfTulips > 7)
        {
            sumFlowers *= 0.95;
        }
        else if (season == "Winter" && numOfRoses >= 10)
        {
            sumFlowers *= 0.90;
        }

        if (totalFlowers > 20)
        {
            sumFlowers *= 0.80;
        }

        sumFlowers += 2;
        Console.WriteLine($"{sumFlowers:F2}");
    }
}
