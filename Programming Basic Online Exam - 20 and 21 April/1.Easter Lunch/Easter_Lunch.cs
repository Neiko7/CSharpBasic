using System;

class Easter_Lunch
{
    static void Main()
    {
        int numberOfEasterEggs = int.Parse(Console.ReadLine());
        int numberOfEggsBark = int.Parse(Console.ReadLine());
        int kilogramsOfCookies = int.Parse(Console.ReadLine());

        double priceOfEasterEggs = numberOfEasterEggs * 3.20;
        double priceForEggs = numberOfEggsBark * 4.35;
        double priceForCookies = kilogramsOfCookies * 5.40;
        double priceForEggPaint = numberOfEggsBark * 12 * 0.15;

        double totalSum = priceOfEasterEggs + priceForEggs + priceForCookies + priceForEggPaint;

        Console.WriteLine($"{totalSum:F2}");
    }
}

