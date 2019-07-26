using System;


class Choreography
{
    static void Main()
    {
        int steps = int.Parse(Console.ReadLine());
        int dancers = int.Parse(Console.ReadLine());
        int daysOfLarning = int.Parse(Console.ReadLine());

        double maxLarningStepsForDay = 13;

        double percentStepsForDay = (double)(steps / daysOfLarning) / steps;
        percentStepsForDay = Math.Ceiling (percentStepsForDay * 100);
           
        double percentStepsForOneDancer = percentStepsForDay / dancers;

        

        if (percentStepsForDay <= maxLarningStepsForDay)
        {
            Console.WriteLine("Yes, they will succeed in that goal! {0:F2}%.", percentStepsForOneDancer );
        }
        else
        {
            Console.WriteLine("No, they will not succeed in that goal! Required {0:F2}% steps to be learned per day.", percentStepsForOneDancer);
        }


    }
}

