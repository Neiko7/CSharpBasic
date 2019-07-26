using System;


class Darts
{
    static void Main()
    {
        string name = Console.ReadLine();

        string typeFlieldField = string.Empty;
        int points = 0;
        int counter = 0;
        int counterRetire = 0;
        int currentPoints = 301;

        while (currentPoints > 0)
        {
            typeFlieldField = Console.ReadLine();

            if (typeFlieldField == "Retire")
            {
                Console.WriteLine($"{name} retired after {counterRetire} unsuccessful shots.");
                return;
            }

            points = int.Parse(Console.ReadLine());



            if (typeFlieldField == "Single")
            {
                int singlePoints = points;

                if (singlePoints <= currentPoints)
                {
                    currentPoints -= singlePoints;
                    counter++;
                }
                else
                {
                    counterRetire++;
                    continue;
                }
            }
            else if (typeFlieldField == "Double")
            {
                int doublePoints = 2 * points;

                if (doublePoints <= currentPoints)
                {
                    currentPoints -= doublePoints;
                    counter++;
                }
                else
                {
                    counterRetire++;
                    continue;
                }
            }
            else if (typeFlieldField == "Triple")
            {
                int triplePoints = 3 * points;

                if (triplePoints <= currentPoints)
                {
                    currentPoints -= triplePoints;
                    counter++;
                }
                else
                {
                    counterRetire++;
                    continue;
                }
            }
        }

        if (currentPoints == 0)
        {
            Console.WriteLine($"{name} won the leg with {counter} shots.");
        }

    }
}

