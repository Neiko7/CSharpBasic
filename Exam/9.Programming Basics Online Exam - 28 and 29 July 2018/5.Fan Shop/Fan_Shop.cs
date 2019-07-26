using System;


class Fan_Shop
{
    static void Main()
    {
        int budget = int.Parse(Console.ReadLine());
        int numberOfItems = int.Parse(Console.ReadLine());
        string item = string.Empty;
        int sum = 0;
        int diff = 0;

        for (int i = 1; i <= numberOfItems; i++)
        {
            item = Console.ReadLine();

            if (item == "hoodie")
            {
                sum += 30;
            }
            else if (item == "keychain")
            {
                sum += 4;
            }
            else if (item == "T-shirt")
            {
                sum += 20;
            }
            else if (item == "flag")
            {
                sum += 15;
            }
            else if (item == "sticker")
            {
                sum += 1;
            }
        }

        diff = Math.Abs(budget - sum);

        if (budget >= sum)
        {
            Console.WriteLine($"You bought {numberOfItems} items and left with {diff} lv.");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {diff} more lv.");
        }
    }
}

