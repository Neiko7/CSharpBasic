using System;


class Christmas_Sweets
{
    static void Main()
    {
        double priceOfBaklava = double.Parse(Console.ReadLine());
        double priceOfmuffins = double.Parse(Console.ReadLine());
        double stollen = double.Parse(Console.ReadLine());
        double candy = double.Parse(Console.ReadLine());
        double biscuits = double.Parse(Console.ReadLine());

        double priceOfStollen = priceOfBaklava * 1.60 * stollen;
        double priceOfCandy = priceOfmuffins * 1.80 * candy;
        double priceOfBiscuits = biscuits * 7.50;

        double totalPrice = priceOfStollen + priceOfCandy + priceOfBiscuits;
        Console.WriteLine($"{totalPrice:F2}");
    }
}

