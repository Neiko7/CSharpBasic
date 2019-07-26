using System;


class Wedding_Seats
{
    static void Main()
    {
        char finalSector = char.Parse(Console.ReadLine());
        int numberOfRowsInFirstSector = int.Parse(Console.ReadLine());
        int numberOfPlacesInAnOddRow = int.Parse(Console.ReadLine());

        int counter = 0;
        bool logic = false;
        int backNumberOfPlacesInAnOddRow = numberOfPlacesInAnOddRow;



        for (int i = 65; i <= finalSector; i++)
        {
            if (logic)
            {
                numberOfRowsInFirstSector++;
                logic = false;
                numberOfPlacesInAnOddRow = backNumberOfPlacesInAnOddRow;
            }

            for (int x = 1; x <= numberOfRowsInFirstSector; x++)
            {
                if (x % 2 == 0)
                {
                    numberOfPlacesInAnOddRow += 2;
                }
                else if (x != 1 && x % 2 != 0)
                {
                    numberOfPlacesInAnOddRow -= 2;
                }



                for (int y = 97; y < 97 + numberOfPlacesInAnOddRow; y++)
                {
                    Console.WriteLine($"{(char)i}{x}{(char)y}");
                    counter++;
                }

            }

            logic = true;

        }

        Console.WriteLine(counter);
    }
}

