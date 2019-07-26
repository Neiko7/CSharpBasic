using System;


class Skeleton
{
    static void Main()
    {
        int minutesOfControl = int.Parse(Console.ReadLine()) * 60;
        int secondsOfControl = int.Parse(Console.ReadLine());
        double lengthOfTheChute = double.Parse(Console.ReadLine());
        int secondTo100Meters = int.Parse(Console.ReadLine());

        int controlInSeconds = minutesOfControl + secondsOfControl;

        double howManyTimesTheTimeWillDecrease = lengthOfTheChute / 120;
        double totalReducedTime = howManyTimesTheTimeWillDecrease * 2.5;

        double timeOfMartin = (lengthOfTheChute / 100) * secondTo100Meters - totalReducedTime;

        if (timeOfMartin <= controlInSeconds)
        {
            Console.WriteLine("Marin Bangiev won an Olympic quota!");
            Console.WriteLine("His time is {0:F3}.", timeOfMartin);
        }
        else
        {
            Console.WriteLine("No, Marin failed! He was {0:F3} second slower.", Math.Abs (controlInSeconds - timeOfMartin));
        }
    }
}

