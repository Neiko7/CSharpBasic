using System;


class Program
{
    static void Main()
    {
        int lenghtPai = int.Parse(Console.ReadLine());
        int weightPai = int.Parse(Console.ReadLine());

        int cake = lenghtPai * weightPai;
        int averigeCake = 0;
        string command = string.Empty;
        int totalCake = 0;

        while (averigeCake <= cake)
        {
            command = Console.ReadLine();

            if (command == "STOP")
            {
                break;
            }

            averigeCake += int.Parse(command);
        }


        if (command == "STOP")
        {
            totalCake = cake - averigeCake;
            Console.WriteLine("{0} pieces are left.", totalCake);
        }
        else
        {
            totalCake = Math.Abs(cake - averigeCake);

            Console.WriteLine("No more cake left! You need {0} pieces more.", totalCake);
        }
    }
}

