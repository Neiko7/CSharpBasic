using System;

class Project_Prize
{
    static void Main()
    {
        int partOfProject = int.Parse(Console.ReadLine());
        double prize = double.Parse(Console.ReadLine());
        double points = 0;
        double sumPoints = 0;
        double totalSum = 0;

        for (int i = 1; i <= partOfProject; i++)
        {
            points = double.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                points *= 2;
                sumPoints += points;
            }
            else
            {
                sumPoints += points;
            }

        }

        totalSum = sumPoints * prize;

        Console.WriteLine($"The project prize was {totalSum:F2} lv.");
    }
}

