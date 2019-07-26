using System;

class Trekking_Equipment 
{
    static void Main()
    {
        int numberOfMountaineers = int.Parse(Console.ReadLine());
        int numberOfCarabiners = int.Parse(Console.ReadLine());
        int numberOfRopes = int.Parse(Console.ReadLine());
        int numberOfPickeys = int.Parse(Console.ReadLine());

        double sumCarabinetrs = numberOfCarabiners * 36;
        double sumRopes = numberOfRopes * 3.60;
        double sumPickeys = numberOfPickeys * 19.80;

        double sumForOneMontaineer = sumCarabinetrs + sumRopes + sumPickeys;
        double sumForMontaineers = numberOfMountaineers * sumForOneMontaineer;
        double totalSum = sumForMontaineers * 1.20;

        Console.WriteLine($"{totalSum:F2}");
    }
}

