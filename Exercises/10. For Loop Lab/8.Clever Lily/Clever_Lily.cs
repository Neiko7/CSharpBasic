using System;


class Clever_Lily
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double washingMashinePrice = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        int toySum = 0;
        int currentSaveMoney = 0;
        double totalSaveMoney = 0;
        int counteYear = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                counteYear++;
            }
            else
            {
                toySum += toyPrice;
            }
        }

        for (int a = 1; a <= counteYear; a++)
        {
            currentSaveMoney += 10 * a;
            currentSaveMoney -= 1;
        }

        totalSaveMoney = toySum + currentSaveMoney;

        if (totalSaveMoney >= washingMashinePrice)
        {
            Console.WriteLine("Yes! {0:F2}", totalSaveMoney - washingMashinePrice);
        }
        else
        {
            Console.WriteLine("No! {0:F2}", washingMashinePrice - totalSaveMoney);
        }
    }
}

