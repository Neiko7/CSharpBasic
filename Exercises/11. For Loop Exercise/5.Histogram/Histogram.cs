using System;


class Histogram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double num = 0;

        double counterP1 = 0;
        double counterP2 = 0;
        double counterP3 = 0;
        double counterP4 = 0;
        double counterP5 = 0;

        double percentP1 = 0.0;
        double percentP2 = 0.0;
        double percentP3 = 0.0;
        double percentP4 = 0.0;
        double percentP5 = 0.0;

        for (int i = 1; i <= n; i++)
        {
            num = double.Parse(Console.ReadLine());

            if (num < 200)
            {
                counterP1++;
            }
            else if (num < 400)
            {
                counterP2++;
            }
            else if (num < 600)
            {
                counterP3++;
            }
            else if (num < 800)
            {
                counterP4++;
            }
            else if (num >= 800)
            {
                counterP5++;
            }
        }

        percentP1 = (counterP1 / n) * 100;
        percentP2 = (counterP2 / n) * 100;
        percentP3 = (counterP3 / n) * 100;
        percentP4 = (counterP4 / n) * 100;
        percentP5 = (counterP5 / n) * 100;

        Console.WriteLine("{0:F2}%", percentP1);
        Console.WriteLine("{0:F2}%", percentP2);
        Console.WriteLine("{0:F2}%", percentP3);
        Console.WriteLine("{0:F2}%", percentP4);
        Console.WriteLine("{0:F2}%", percentP5);
    }
}

