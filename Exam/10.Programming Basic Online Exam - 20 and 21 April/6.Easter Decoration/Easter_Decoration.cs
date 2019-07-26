using System;

class Easter_Decoration
{
    static void Main()
    {
        int numberOfCustomers = int.Parse(Console.ReadLine());

        string purchase = string.Empty;

        double basket = 1.50;
        double wreath = 3.80;
        double chocolateBunny = 7.0;

        int counter = 0;
        double sum = 0.0;
        double totalSum = 0.0;
        double averageSum = 0.0;

        for (int i = 1; i <= numberOfCustomers; i++)
        {
            while ((purchase = Console.ReadLine()) != "Finish")
            {
                counter++;

                if (purchase == "basket")
                {
                    sum += basket;
                }
                else if (purchase == "wreath")
                {
                    sum += wreath;
                }
                else if (purchase == "chocolate bunny")
                {
                    sum += chocolateBunny;
                }
            }

            if (counter % 2 == 0)
            {
                sum *= 0.80;
            }
            Console.WriteLine($"You purchased {counter} items for {sum:F2} leva.");
            totalSum += sum;
            counter = 0;            
            sum = 0;
        }

        averageSum = totalSum / numberOfCustomers;
        Console.WriteLine($"Average bill per client is: {averageSum:F2} leva.");
    }
}

