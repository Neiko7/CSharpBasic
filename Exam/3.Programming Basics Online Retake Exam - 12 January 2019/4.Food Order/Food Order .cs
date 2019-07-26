using System;


class Food_Order
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());

        string nameOfProduct = Console.ReadLine();
        double priceOfProduct = 0.0;
        int counter = 0;
        double totalPrice = 2.5;

        while (nameOfProduct != "Order")
        {

            priceOfProduct = double.Parse(Console.ReadLine());
            

            if (totalPrice + priceOfProduct <= budget)
            {
                totalPrice += priceOfProduct;
                counter++;
            }
            else
            {
                Console.WriteLine("You will exceed the budget if you order this!");
            }

            nameOfProduct = Console.ReadLine();
        }

        Console.WriteLine($"You ordered {counter} items!");
        Console.WriteLine($"Total: {totalPrice:F2}");
    }
}

