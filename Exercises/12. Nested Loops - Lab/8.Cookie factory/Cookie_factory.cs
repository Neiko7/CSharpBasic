using System;


class Cookie_factory
{
    static void Main()
    {
        int part = int.Parse(Console.ReadLine());

        bool flourChek = false;
        bool eggsChek = false;
        bool sugarChek = false;
        int counter = 0;

        for (int i = 1; i <= part; i++)
        {
            string product = Console.ReadLine();

            while (product != "Bake!")
            {
                if (product == "flour")
                {
                    flourChek = true;
                }
                if (product == "eggs")
                {
                    eggsChek = true;
                }
                if (product == "sugar")
                {
                    sugarChek = true;
                }

                product = Console.ReadLine();
            }

            if (flourChek && eggsChek && sugarChek)
            {
                counter++;
                Console.WriteLine($"Baking batch number {counter}...");
                flourChek = false;
                eggsChek = false;
                sugarChek = false;
            }
            else
            {
                part++;
                Console.WriteLine($"The batter should contain flour, eggs and sugar!");
            }
        }
    }
}
