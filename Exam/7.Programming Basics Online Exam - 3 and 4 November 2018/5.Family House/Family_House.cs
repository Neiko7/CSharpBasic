using System;


class Family_House
{
    static void Main()
    {
        double numOfMonth = double.Parse(Console.ReadLine());

        double electricityForMonth = 0;
        double totalSumForElectricity = 0;
        double totalSumForWater = 0;
        double totalSumForInternet = 0;
        double otherSumForMonth = 0;
        double totalSumForOther = 0;
        double averageFotMonth = 0;


        for (int i = 1; i <= numOfMonth; i++)
        {
            electricityForMonth = double.Parse(Console.ReadLine());
            totalSumForElectricity += electricityForMonth;

            otherSumForMonth = (electricityForMonth + 20 + 15) * 1.20;
            totalSumForOther += otherSumForMonth;

        }

        totalSumForWater = numOfMonth * 20;
        totalSumForInternet = numOfMonth * 15;
        averageFotMonth = (totalSumForElectricity + totalSumForWater + totalSumForInternet + totalSumForOther) / numOfMonth;

        Console.WriteLine($"Electricity: {totalSumForElectricity:F2} lv");
        Console.WriteLine($"Water: {totalSumForWater:F2} lv");
        Console.WriteLine($"Internet: {totalSumForInternet:F2} lv");
        Console.WriteLine($"Other: {totalSumForOther:F2} lv");
        Console.WriteLine($"Average: {averageFotMonth:F2} lv");
    }
}

