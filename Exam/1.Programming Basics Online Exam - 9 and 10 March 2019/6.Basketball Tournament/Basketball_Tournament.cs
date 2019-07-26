using System;


class Basketball_Tournament
{
    static void Main()
    {
        string tournament = Console.ReadLine();


        double counterWin = 0;
        double counterLost = 0;
        double counterMatch = 0;
        double percentWin = 0;
        double percentLost = 0;

        while (tournament != "End of tournaments")
        {
            int numOfMatch = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOfMatch; i++)
            {
                int hostTeam = int.Parse(Console.ReadLine());
                int visitingTeam = int.Parse(Console.ReadLine());

                int diff = Math.Abs(hostTeam - visitingTeam);

                if (hostTeam > visitingTeam)
                {
                    counterWin++;
                    Console.WriteLine($"Game {i} of tournament {tournament}: win with {diff} points.");
                }
                else if (hostTeam < visitingTeam)
                {
                    counterLost++;
                    Console.WriteLine($"Game {i} of tournament {tournament}: lost with {diff} points.");
                }
                counterMatch++;
            }

            tournament = Console.ReadLine();
        }



        percentWin = (counterWin / counterMatch) * 100;
        percentLost = (counterLost / counterMatch) * 100;

        Console.WriteLine($"{percentWin:F2}% matches win");
        Console.WriteLine($"{percentLost:F2}% matches lost");
    }
}

