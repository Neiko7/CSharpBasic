using System;


class Wedding_Presents 
{
    static void Main()
    {
        double totalNumberOfGuests = int.Parse(Console.ReadLine());
        double numberOfGifts = int.Parse(Console.ReadLine());
        char simbol = '\0';

        double counterA = 0;
        double counterB = 0;
        double counterV = 0;
        double counterG = 0;

        double percentA = 0;
        double percentB = 0;
        double percentV = 0;
        double percentG = 0;
        double percentGuests = 0;

        for (int i = 1; i <= numberOfGifts; i++)
        {
            simbol = char.Parse(Console.ReadLine());

            if (simbol == 'A')
            {
                counterA++;
            }
            else if (simbol == 'B')
            {
                counterB++;
            }
            else if (simbol == 'V')
            {
                counterV++;
            }
            else if (simbol == 'G')
            {
                counterG++;
            }
        }

        percentA = (counterA / numberOfGifts) * 100;
        percentB = (counterB / numberOfGifts) * 100;
        percentV = (counterV / numberOfGifts) * 100;
        percentG = (counterG / numberOfGifts) * 100;

        percentGuests = (numberOfGifts / totalNumberOfGuests) * 100;

        Console.WriteLine($"{percentA:F2}%");
        Console.WriteLine($"{percentB:F2}%");
        Console.WriteLine($"{percentV:F2}%");
        Console.WriteLine($"{percentG:F2}%");
        Console.WriteLine($"{percentGuests:F2}%");

    }
}

