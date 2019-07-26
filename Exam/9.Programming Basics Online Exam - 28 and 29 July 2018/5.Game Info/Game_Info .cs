using System;


class Game_Info 
{
    static void Main()
    {
        string nameOfTeam = Console.ReadLine();
        int numberOfGames = int.Parse(Console.ReadLine());
        int durationOfTheMeeting = 0;
        double sum = 0;
        int counterAdditionalTime = 0;
        int counterPenalties = 0;

        for (int i = 1; i <= numberOfGames; i++)
        {
            durationOfTheMeeting = int.Parse(Console.ReadLine());
            sum += durationOfTheMeeting;

            if (durationOfTheMeeting > 120)
            {
                counterPenalties++;
            }
            else if(durationOfTheMeeting > 90)
            {
                counterAdditionalTime++;
            }

        }

        Console.WriteLine($"{nameOfTeam} has played {sum} minutes. Average minutes per game: {sum / numberOfGames:F2}");
        Console.WriteLine($"Games with penalties: {counterPenalties}");
        Console.WriteLine($"Games with additional time: {counterAdditionalTime}");
    }
}

