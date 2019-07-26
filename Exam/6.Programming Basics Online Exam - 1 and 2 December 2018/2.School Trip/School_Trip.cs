using System;


class School_Trip
{
    static void Main()
    {
        int numberOfDays = int.Parse(Console.ReadLine());
        int foodLeftInKilograms = int.Parse(Console.ReadLine());
        double foodPerDayForFirstDog = double.Parse(Console.ReadLine());
        double foodPerDayForSecondDog = double.Parse(Console.ReadLine());
        double foodPerDayForThirdDog = double.Parse(Console.ReadLine());

        double firstDog = numberOfDays * foodPerDayForFirstDog;
        double secondDog = numberOfDays * foodPerDayForSecondDog;
        double thirdDog = numberOfDays * foodPerDayForThirdDog;
        double totalFood = firstDog + secondDog + thirdDog;

        double diff = Math.Abs(totalFood - foodLeftInKilograms);

        if (totalFood <= foodLeftInKilograms)
        {
            diff = Math.Floor(diff);
            Console.WriteLine($"{diff} kilos of food left.");
        }
        else 
        {
            diff = Math.Ceiling(diff);
            Console.WriteLine($"{diff} more kilos of food are needed.");
        }
    }
}

