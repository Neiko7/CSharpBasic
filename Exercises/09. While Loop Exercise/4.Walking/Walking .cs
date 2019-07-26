using System;


class Program
{
    static void Main()
    {
        int steps = 0;
        int finishSteps = 0;
        int totalSteps = 0;

        while (steps < 10000)
        {
            string momentSteps = Console.ReadLine();

            if (momentSteps == "Going home")
            {
                finishSteps = int.Parse(Console.ReadLine());
                break;
            }
            else
            {
                steps += int.Parse(momentSteps);
            }
        }

        totalSteps = steps + finishSteps;

        if (totalSteps >= 10000)
        {
            Console.WriteLine("Goal reached! Good job!");
        }
        else
        {
            Console.WriteLine("{0} more steps to reach goal.", 10000 - totalSteps);
        }
    }
}

