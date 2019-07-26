using System;

class Football_Souvenirs
{
    static void Main()
    {
        string nameOfTeam = Console.ReadLine();
        string kindOfSouvenir = Console.ReadLine();
        int numberOfPurchasedSouvenirs = int.Parse(Console.ReadLine());

        double sum = 0.0;
        double totalSum = 0.0;
        

        if (nameOfTeam == "Argentina")
        {
            if (kindOfSouvenir == "flags")
            {
                sum = 3.25;
            }
            else if (kindOfSouvenir == "caps")
            {
                sum = 7.20;
            }
            else if (kindOfSouvenir == "posters")
            {
                sum = 5.10;
            }
            else if (kindOfSouvenir == "stickers")
            {
                sum = 1.25;
            }
            else
            {
                Console.WriteLine("Invalid stock!");
                return;
            }
        }
        else if (nameOfTeam == "Brazil")
        {
            if (kindOfSouvenir == "flags")
            {
                sum = 4.20;
            }
            else if (kindOfSouvenir == "caps")
            {
                sum = 8.50;
            }
            else if (kindOfSouvenir == "posters")
            {
                sum = 5.35;
            }
            else if (kindOfSouvenir == "stickers")
            {
                sum = 1.20;
            }
            else
            {
                Console.WriteLine("Invalid stock!");
                return;
            }
        }
        else if (nameOfTeam == "Croatia")
        {
            if (kindOfSouvenir == "flags")
            {
                sum = 2.75;
            }
            else if (kindOfSouvenir == "caps")
            {
                sum = 6.90;
            }
            else if (kindOfSouvenir == "posters")
            {
                sum = 4.95;
            }
            else if (kindOfSouvenir == "stickers")
            {
                sum = 1.10;
            }
            else
            {
                Console.WriteLine("Invalid stock!");
                return;
            }
        }
        else if (nameOfTeam == "Denmark")
        {
            if (kindOfSouvenir == "flags")
            {
                sum = 3.10;
            }
            else if (kindOfSouvenir == "caps")
            {
                sum = 6.50;
            }
            else if (kindOfSouvenir == "posters")
            {
                sum = 4.80;
            }
            else if (kindOfSouvenir == "stickers")
            {
                sum = 0.90;
            }
            else
            {
                Console.WriteLine("Invalid stock!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid country!");
            return;
        }

        totalSum = numberOfPurchasedSouvenirs * sum;

        Console.WriteLine($"Pepi bought {numberOfPurchasedSouvenirs} {kindOfSouvenir} of {nameOfTeam} for {totalSum:F2} lv.");
    }
}
