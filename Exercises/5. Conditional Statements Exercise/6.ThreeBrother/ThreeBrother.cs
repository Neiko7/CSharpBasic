using System;

class ThreeBrother
{
    static void Main()
    {
        double firstBrother = double.Parse(Console.ReadLine());
        double secondBrother = double.Parse(Console.ReadLine());
        double thirdBrother = double.Parse(Console.ReadLine());
        double fishingTime = double.Parse(Console.ReadLine());

        double allTimeCleaning = 1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother);
        double allTimeCleaningAndBreak = allTimeCleaning * 1.15;
        double timeLeft = fishingTime - allTimeCleaningAndBreak;


        Console.WriteLine("Cleaning time: {0:F2}", allTimeCleaningAndBreak);

        if (timeLeft >= 0)
        {
            Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(timeLeft));
        }
        else
        {
            Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(Math.Abs(timeLeft)));
        }
    }
}
