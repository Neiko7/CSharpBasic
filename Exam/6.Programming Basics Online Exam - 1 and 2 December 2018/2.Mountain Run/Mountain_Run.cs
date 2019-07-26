using System;

class Mountain_Run
{
    static void Main()
    {
        double recordInSeconds = double.Parse(Console.ReadLine());
        double distanceInMeters = double.Parse(Console.ReadLine());
        double timeForOneMeter = double.Parse(Console.ReadLine());

        double climbTime = distanceInMeters * timeForOneMeter;
        double extraTimeToClimb = Math.Floor((distanceInMeters / 50)) * 30;
        double totalTime = climbTime + extraTimeToClimb;

        if (totalTime < recordInSeconds)
        {
            Console.WriteLine($"Yes! The new record is {totalTime:F2} seconds.");
        }
        else
        {
            double diff = totalTime - recordInSeconds;
            Console.WriteLine($"No! He was {diff:F2} seconds slower.");
        }

    }
}

