using System;


class WorldSwimmingRecord
{
    static void Main()
    {
        double recordInSeconds = double.Parse(Console.ReadLine());
        double distanceInMeters = double.Parse(Console.ReadLine());
        double timeInSeocnds = double.Parse(Console.ReadLine());

        double swimmingInSeconds = distanceInMeters * timeInSeocnds;
        double slowInSeconds = Math.Floor (distanceInMeters / 15);
        slowInSeconds *= 12.5;

        double totalTime = swimmingInSeconds + slowInSeconds;

        if (recordInSeconds > totalTime)
        {
            Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", totalTime);
        }
        else
        {
            Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", Math.Abs (recordInSeconds - totalTime));
        }
      
    }
}
