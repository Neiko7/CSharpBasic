using System;


class Football_Results
{
    static void Main()
    {
        string firstMatch = Console.ReadLine();
        string secondMatch = Console.ReadLine();
        string thirdMatch = Console.ReadLine();

        int counterWon= 0;
        int counterLost = 0;
        int counterDrawnGames = 0;

        char HostFirstMatch = firstMatch[0];
        char GuestFirstMatch = firstMatch[2];
        char HostSecondMatch = secondMatch[0];
        char GuestSecondMatch = secondMatch[2];
        char HostThirdMatch = thirdMatch[0];
        char GuestThirdMatch = thirdMatch[2];

        if (HostFirstMatch > GuestFirstMatch)
        {
            counterWon++;
        }
        else if (HostFirstMatch < GuestFirstMatch)
        {
            counterLost++;
        }
        else if (HostFirstMatch == GuestFirstMatch)
        {
            counterDrawnGames++;
        }


        if (HostSecondMatch > GuestSecondMatch)
        {
            counterWon++;
        }
        else if (HostSecondMatch < GuestSecondMatch)
        {
            counterLost++;
        }
        else if (HostSecondMatch == GuestSecondMatch)
        {
            counterDrawnGames++;
        }


        if (HostThirdMatch > GuestThirdMatch)
        {
            counterWon++;
        }
        else if (HostThirdMatch < GuestThirdMatch)
        {
            counterLost++;
        }
        else if (HostThirdMatch == GuestThirdMatch)
        {
            counterDrawnGames++;
        }



        Console.WriteLine("Team won {0} games.", counterWon);
        Console.WriteLine("Team lost {0} games.", counterLost);
        Console.WriteLine("Drawn games: {0}", counterDrawnGames);
    }
}

