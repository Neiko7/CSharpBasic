using System;

class Divide_Without_Remaider
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double counterP1 = 0;
        double counterP2 = 0;
        double counterP3 = 0;

        double percentP1 = 0;
        double percentP2 = 0;
        double percentP3 = 0;

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                counterP1++;
            }
            if (num % 3 == 0)
            {
                counterP2++;
            }
            if (num % 4 == 0)
            {
                counterP3++;
            }
        }

        percentP1 = (counterP1 / n) * 100;
        percentP2 = (counterP2 / n) * 100;
        percentP3 = (counterP3 / n) * 100;

        Console.WriteLine("{0:F2}%", percentP1);
        Console.WriteLine("{0:F2}%", percentP2);
        Console.WriteLine("{0:F2}%", percentP3);
    }
}

