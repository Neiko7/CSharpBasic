using System;


class Basketball_Equipment
{
    static void Main()
    {
        double sum = double.Parse(Console.ReadLine());
        double totalsum = 0;

        double sneakers = sum * 0.6;
        double outfit = sneakers - (sneakers * 0.2);
        double ball = outfit / 4;
        double accessories = ball / 5;

        totalsum = sum + sneakers + outfit + ball + accessories;

        Console.WriteLine($"{totalsum:F2}");
    }
}

