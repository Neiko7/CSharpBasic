using System;


class Game_Number_Wars
{
    static void Main()
    {
        string firstPlayer = Console.ReadLine();
        string secondPlayer = Console.ReadLine();
        int pointOfFirstPlayer = 0;
        int pointOfSecondPlayer = 0;
        string firstPlayerCard = string.Empty;
        string secondPlayerCard = string.Empty;
        int firstPlayerCardToInt = 0;
        int secondPlayerCardToInt = 0;
        

        int counter = 0;

        while (counter <= 36)
        {
            firstPlayerCard = Console.ReadLine();
            if (firstPlayerCard == "End of game")
            {
                Console.WriteLine($"{firstPlayer} has {pointOfFirstPlayer} points");
                Console.WriteLine($"{secondPlayer} has {pointOfSecondPlayer} points");
                return;
            }
            secondPlayerCard = Console.ReadLine();

            if (secondPlayerCard == "End of game")
            {
                Console.WriteLine($"{firstPlayer} has {pointOfFirstPlayer} points");
                Console.WriteLine($"{secondPlayer} has {pointOfSecondPlayer} points");
                return;
            }

            firstPlayerCardToInt = int.Parse(firstPlayerCard);
            secondPlayerCardToInt = int.Parse(secondPlayerCard);

            int differentPoints = Math.Abs(firstPlayerCardToInt - secondPlayerCardToInt);


            counter += 2;

            if (firstPlayerCardToInt > secondPlayerCardToInt)
            {
                pointOfFirstPlayer += differentPoints;
            }
            else if (firstPlayerCardToInt < secondPlayerCardToInt)
            {
                pointOfSecondPlayer += differentPoints;
            }
            else if (firstPlayerCardToInt == secondPlayerCardToInt)
            {
                Console.WriteLine("Number wars!");

                firstPlayerCardToInt = int.Parse(Console.ReadLine());
                secondPlayerCardToInt = int.Parse(Console.ReadLine());

                if (firstPlayerCardToInt > secondPlayerCardToInt)
                {
                    Console.WriteLine($"{firstPlayer} is winner with {pointOfFirstPlayer} points");

                    return;
                }
                else if (firstPlayerCardToInt < secondPlayerCardToInt)
                {
                    Console.WriteLine($"{secondPlayer} is winner with {pointOfSecondPlayer} points");

                    return;
                }


            }

        }

    }
}

