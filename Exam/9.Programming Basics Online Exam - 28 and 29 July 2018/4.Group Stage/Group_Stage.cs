using System;


class Group_Stage
{
    static void Main()
    {
        string nameOfTeam = Console.ReadLine();
        int numberOfMatch = int.Parse(Console.ReadLine());

        int points = 0;
        int totalGoalDifference = 0;
        int sumGoalsScored = 0;
        int sumObtainedGoals = 0;

        for (int i = 1; i <= numberOfMatch; i++)
        {
            int goalsScored = int.Parse(Console.ReadLine());
            int obtainedGoals = int.Parse(Console.ReadLine());

            sumGoalsScored += goalsScored;
            sumObtainedGoals += obtainedGoals;

            if (goalsScored > obtainedGoals)
            {
                points += 3;
            }
            else if (goalsScored == obtainedGoals)
            {
                points += 1;
            }            
        }

        totalGoalDifference = sumGoalsScored - sumObtainedGoals;

        if (sumGoalsScored >= sumObtainedGoals)
        {
            Console.WriteLine($"{nameOfTeam} has finished the group phase with {points} points.");
            Console.WriteLine($"Goal difference: {totalGoalDifference}.");
        }
        else
        {
            Console.WriteLine($"{nameOfTeam} has been eliminated from the group phase.");
            Console.WriteLine($"Goal difference: {totalGoalDifference}.");
        }

    }
}

