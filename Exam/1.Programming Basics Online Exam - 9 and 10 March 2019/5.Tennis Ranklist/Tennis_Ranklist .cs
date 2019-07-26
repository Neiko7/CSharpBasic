using System;


class Tennis_Ranklist
{
    static void Main()
    {
        int numberOfTournaments = int.Parse(Console.ReadLine());
        int startingPoints = int.Parse(Console.ReadLine());

        double counter = 0.0;
        string stage = string.Empty;
        double currentPoints = startingPoints;
        double averagePoints = 0.0;
        double percentWin = 0.0;



        for (int i = 1; i <= numberOfTournaments; i++)
        {
            stage = Console.ReadLine();

            if (stage == "W")
            {
                currentPoints += 2000;
                counter++;
            }
            else if (stage == "F")
            {
                currentPoints += 1200;
            }
            else if (stage == "SF")
            {
                currentPoints += 720;
            }

        }

        averagePoints = Math.Floor((currentPoints - startingPoints) / numberOfTournaments);
        percentWin = (counter / numberOfTournaments) * 100;

        Console.WriteLine($"Final points: {currentPoints}");
        Console.WriteLine($"Average points: {averagePoints}");
        Console.WriteLine($"{percentWin:F2}%");
    }
}

