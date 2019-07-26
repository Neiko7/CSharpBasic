using System;


class Shopping_Time 
{
    static void Main()
    {
        int timeForABreak = int.Parse(Console.ReadLine());
        double costPerPeripheralPart = double.Parse(Console.ReadLine());
        double costPerProgram = double.Parse(Console.ReadLine());
        double priceForWhiteFrappe = double.Parse(Console.ReadLine());

        double timeForPurchase = 5 + (3 * 2) + (2 * 2);
        double timeForRelaxation = timeForABreak - timeForPurchase;
        double totalSum = priceForWhiteFrappe + (3 * costPerPeripheralPart) + (2 * costPerProgram);

        Console.WriteLine($"{totalSum:F2}");
        Console.WriteLine(timeForRelaxation);


    }
}

