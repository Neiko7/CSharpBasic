using System;


class Pastry_Shop 
{
    static void Main()
    {
        string sweet = Console.ReadLine();
        int numOfSweet = int.Parse(Console.ReadLine());
        int dayOfMonth = int.Parse(Console.ReadLine());

        double sumSweet = 0;

        if (sweet == "Cake")
        {
            if (dayOfMonth <= 15)
            {
                sumSweet = numOfSweet * 24;
            }
            else if (dayOfMonth > 15)
            {
                sumSweet = numOfSweet * 28.70;
            }
        }
        else if (sweet == "Souffle")
        {
            if (dayOfMonth <= 15)
            {
                sumSweet = numOfSweet * 6.66;
            }
            else if (dayOfMonth > 15)
            {
                sumSweet = numOfSweet * 9.80;
            }
        }
        else if (sweet == "Baklava")
        {
            if (dayOfMonth <= 15)
            {
                sumSweet = numOfSweet * 12.60;
            }
            else if (dayOfMonth > 15)
            {
                sumSweet = numOfSweet * 16.98;
            }
        }

        if (dayOfMonth <= 22)
        {
            if (sumSweet >= 100 && sumSweet <= 200)
            {
                sumSweet *= 0.85;
            }
            else if (sumSweet > 200)
            {
                sumSweet *= 0.75;
            }

            if (dayOfMonth <= 15)
            {
                sumSweet *= 0.90;
            }
        }

        Console.WriteLine($"{sumSweet:F2}");
    }
}

