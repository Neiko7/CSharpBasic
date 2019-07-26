using System;


class Fishing
{
    static void Main()
    {
        int numberOfFish = int.Parse(Console.ReadLine());
        string nameOfFish = string.Empty;
        double kilogramsOfFish = 0;
        double amountOfFishName = 0;
        double earnedmoney = 0;
        double lostMoney = 0;
        double diff = 0;
        int counter = 0;

        while ((nameOfFish = Console.ReadLine()) != "Stop")
        {
            kilogramsOfFish = double.Parse(Console.ReadLine());
            int fish = nameOfFish.Length - 1;
            counter++;

            for (int j = 0; j <= fish; j++)
            {
                int sum = nameOfFish[j];
                amountOfFishName += sum;
            }

            if (counter % 3 == 0)
            {
                earnedmoney += (amountOfFishName / kilogramsOfFish);
            }
            else
            {
                lostMoney += (amountOfFishName / kilogramsOfFish);
            }

            amountOfFishName = 0;
            
            if (counter == numberOfFish)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
                break;
            }
        }

        diff = Math.Abs(earnedmoney - lostMoney);

        if (earnedmoney > lostMoney)
        {
            Console.WriteLine($"Lyubo's profit from {counter} fishes is {diff:F2} leva. ");
        }
        else
        {
            Console.WriteLine($"Lyubo lost {diff:F2} leva today.");
        }
    }
}

