using System;


class New_House
{
    static void Main()
    {
        string typeFlowers = Console.ReadLine();
        int numberOfFlowers = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());


        double priceOfRoses = 5.00;
        double priceOfDahlias = 3.80;
        double priceOfTulips = 2.80;
        double priceOfNarcissus = 3.00;
        double priceOfGladiolus = 2.50;

        double discountOver80Roses = 0.90;
        double discountOver90Dahlias = 0.85;
        double discountOver80Tulips = 0.85;
        double notDiscountLessThan120Narcissus = 1.15;
        double notDiscountLessThan120Gladiolus = 1.20;

        double price = 0.0;

        if (typeFlowers == "Roses")
        {
            price = numberOfFlowers * priceOfRoses;

            if (numberOfFlowers > 80)
            {
                price *= discountOver80Roses;
            }
        }
        else if (typeFlowers == "Dahlias")
        {
            price = numberOfFlowers * priceOfDahlias;

            if (numberOfFlowers > 90)
            {

                price *= discountOver90Dahlias;
            }
        }
        else if (typeFlowers == "Tulips")
        {
            price = numberOfFlowers * priceOfTulips;

            if (numberOfFlowers > 80)
            {
                price = price * discountOver80Tulips;
            }
        }
        else if (typeFlowers == "Narcissus")
        {
            price = numberOfFlowers * priceOfNarcissus;

            if (numberOfFlowers < 120)
            {
                price *= notDiscountLessThan120Narcissus;
            }
        }
        else if (typeFlowers == "Gladiolus")
        {
            price = numberOfFlowers * priceOfGladiolus;

            if (numberOfFlowers < 80)
            {
                price = price * notDiscountLessThan120Gladiolus;
            }
        }

        if (budget >= price)
        {
            Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.",
                numberOfFlowers, typeFlowers, budget - price);
        }
        else
        {
            Console.WriteLine("Not enough money, you need {0:F2} leva more.", price - budget);
        }
    }
}

