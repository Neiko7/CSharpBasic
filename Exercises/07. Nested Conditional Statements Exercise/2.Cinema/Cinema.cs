using System;


class Cinema
{
    static void Main()
    {
        string typeCinema = Console.ReadLine().ToLower();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        double premiere = 12.00;
        double normal = 7.50;
        double discount = 5.00;

        int fullCimena = rows * columns;

        double income = 0.0;

        if (typeCinema == "premiere")
        {
            income = fullCimena * premiere;
        }
        else if (typeCinema == "normal")
        {
            income = fullCimena * normal;
        }
        else if (typeCinema == "discount")
        {
            income = fullCimena * discount;
        }

        Console.WriteLine($"{income:F2} leva");
    }
}
