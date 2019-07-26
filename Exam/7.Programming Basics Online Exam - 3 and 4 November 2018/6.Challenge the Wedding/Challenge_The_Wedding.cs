using System;

class Challenge_The_Wedding
{
    static void Main()
    {
        int men = int.Parse(Console.ReadLine());
        int women = int.Parse(Console.ReadLine());
        int maxNumberTable = int.Parse(Console.ReadLine());

        int counter = 0;

       
        for (int x = 1; x <= men; x++)
        {
            if (x > men)
            {
                return;
            }

            for (int y = 1; y <= women; y++)
            {
                Console.Write($"({x} <-> {y}) ");
                counter++;

                if (counter == maxNumberTable)
                {
                    return;
                }
            }

        }
       
    }
}

