using System;


class ToyShop
{
    static void Main()
    {
        double puzzle = 2.60;
        double speakingDoll = 3.0;
        double teddyBear = 4.10;
        double minion = 8.20;
        double truck = 2.0;

        double excursionPrice = double.Parse(Console.ReadLine());
        int numberOfPuzzle = int.Parse(Console.ReadLine());
        int numberOfSpeakingDoll = int.Parse(Console.ReadLine());
        int numberOfTedyyBear = int.Parse(Console.ReadLine());
        int numberOfMinion = int.Parse(Console.ReadLine());
        int numberOfTruck = int.Parse(Console.ReadLine());

        double sum = (numberOfPuzzle * puzzle) + (numberOfSpeakingDoll * speakingDoll) + (numberOfTedyyBear * teddyBear)
            + (numberOfMinion * minion) + (numberOfTruck * truck);

        int toySum = numberOfPuzzle + numberOfSpeakingDoll + numberOfTedyyBear + numberOfMinion + numberOfTruck;
        double discount = 0.0;

        if (toySum >= 50)
        {
            discount = sum * 0.25;
        }

        double finishSum = sum - discount;
        double rent = finishSum * 0.1;
        finishSum = finishSum - rent;

        if (excursionPrice <= finishSum)
        {
            double remainingMoney = finishSum - excursionPrice;
            Console.WriteLine("Yes! {0:F2} lv left.", remainingMoney);
        }
        else
        {
            double shortageOfMoney = excursionPrice - finishSum;
            Console.WriteLine("Not enough money! {0:F2} lv needed.", Math.Abs(shortageOfMoney));
        }
    }
}

