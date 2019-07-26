using System;


class Change_Bureau 
{
    static void Main()
    {
        int numOfBitkine = int.Parse(Console.ReadLine());
        double numOfChineseYuan = double.Parse(Console.ReadLine());
        double commission = double.Parse(Console.ReadLine());

        double sumBitkineToBg = numOfBitkine * 1168;
        double sumChineseYuanToUsd = numOfChineseYuan * 0.15;
        double sumChineseYuanToBg = sumChineseYuanToUsd * 1.76;
        double sumBgToEuro = (sumBitkineToBg + sumChineseYuanToBg) / 1.95;

        double sumCommission =  sumBgToEuro - (sumBgToEuro * (commission / 100));

        Console.WriteLine($"{sumCommission:F2}");
    }
}

