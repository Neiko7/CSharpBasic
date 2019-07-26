using System;

class Fitness_Center
{
    static void Main()
    {
        int numberOfVisitors = int.Parse(Console.ReadLine());

        string activityInTheGym = string.Empty;
        double visitorsHaveTrained = 0.0;
        double visitorsHavePurchasedProducts = 0.0;
        double percentTraining = 0.0;
        double percentProducts = 0.0;

        double counterBack = 0.0;
        double counterChest = 0.0;
        double counterLegs = 0.0;
        double counterAbs = 0.0;
        double counterProteinShake = 0.0;
        double counterProteinBar = 0.0;

        for (int i = 1; i <= numberOfVisitors; i++)
        {
            activityInTheGym = Console.ReadLine();

            if (activityInTheGym == "Back")
            {
                counterBack++;
            }
            else if (activityInTheGym == "Chest")
            {
                counterChest++;
            }
            else if (activityInTheGym == "Legs")
            {
                counterLegs++;
            }
            else if (activityInTheGym == "Abs")
            {
                counterAbs++;
            }
            else if (activityInTheGym == "Protein shake")
            {
                counterProteinShake++;
                --i;
            }
            else if (activityInTheGym == "Protein bar")
            {
                counterProteinBar++;
                --i;
            }
        }

        visitorsHaveTrained = counterBack + counterChest + counterLegs + counterAbs;
        visitorsHavePurchasedProducts = counterProteinShake + counterProteinBar;

        percentTraining = (visitorsHaveTrained / numberOfVisitors) * 100;
        percentProducts = (visitorsHavePurchasedProducts / numberOfVisitors) * 100;

        Console.WriteLine($"{counterBack} - back");
        Console.WriteLine($"{counterChest} - chest");
        Console.WriteLine($"{counterLegs} - legs");
        Console.WriteLine($"{counterAbs} - abs");
        Console.WriteLine($"{counterProteinShake} - protein shake");
        Console.WriteLine($"{counterProteinBar} - protein bar");
        Console.WriteLine($"{percentTraining:F2}% - work out");
        Console.WriteLine($"{percentProducts:F2}% - protein");
    }
}

