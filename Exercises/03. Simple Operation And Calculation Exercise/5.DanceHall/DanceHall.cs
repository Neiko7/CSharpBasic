using System;

class DanceHall
{
    static void Main()
    {
        double lengthHall = double.Parse(Console.ReadLine());
        double wigthHall = double.Parse(Console.ReadLine());
        double sizeAWardrobe = double.Parse(Console.ReadLine());

        double areaHall = (lengthHall * 100) * (wigthHall * 100);
        double areaWardrobe = (sizeAWardrobe * 100) * (sizeAWardrobe * 100);
        double areaBench = areaHall / 10;
        double freeSpaceHall = areaHall - areaWardrobe - areaBench;
        int dancer = (int) Math.Floor (freeSpaceHall / (40 + 7000));

        Console.WriteLine(dancer);

    }
}

