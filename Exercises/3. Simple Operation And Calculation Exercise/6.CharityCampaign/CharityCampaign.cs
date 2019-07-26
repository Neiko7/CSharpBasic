using System;


class CharityCampaign
{
    static void Main()
    {
        int allDays = int.Parse(Console.ReadLine());
        int allBakhers = int.Parse(Console.ReadLine());
        int cakesOfDay = int.Parse(Console.ReadLine());
        int waferOfDay = int.Parse(Console.ReadLine());
        int pancakesOfDay = int.Parse(Console.ReadLine());

        double cakesSum = cakesOfDay * 45;
        double waferSum = waferOfDay * 5.80;
        double pancakesSum = pancakesOfDay * 3.20;
        double allSumOfDay = (cakesSum + waferSum + pancakesSum) * allBakhers;
        double allSum = allSumOfDay * allDays;
        double totalSum = allSum - (allSum / 8);

        Console.WriteLine("{0:F2}", totalSum);
    }
}

