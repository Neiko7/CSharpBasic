using System;


class Pinema_Tickets 
{
    static void Main()
    {
        string nameOfMovie = Console.ReadLine();

        string tikets = string.Empty;
        int counterStudentOne = 0;
        int counterStandartOne = 0;
        int counterKidOne = 0;
        int counterStudentTwo = 0;
        int counterStandartTwo = 0;
        int counterKidTwo = 0;

        double counterMovie = 0;
        double totalTikets = 0;
        double percentMovie = 0.0;
        double percentStudentTikets = 0.0;
        double percentStandartTikets = 0.0;
        double percentKidTikets = 0.0;
        

        while (nameOfMovie != "Finish")
        {
            int freePlaces = int.Parse(Console.ReadLine());

            for (int i = 1; i <= freePlaces; i++)
            {
                tikets = Console.ReadLine();

                if (tikets == "End")
                {
                    break;
                }
                else if (tikets == "student")
                {
                    counterStudentOne++;
                }
                else if (tikets == "standard")
                {
                    counterStandartOne++;
                }
                else if (tikets == "kid")
                {
                    counterKidOne++;
                }

            }
            counterStudentTwo += counterStudentOne;
            counterStandartTwo += counterStandartOne;
            counterKidTwo += counterKidOne;
            counterMovie = counterStudentOne + counterStandartOne + counterKidOne;
            percentMovie = (counterMovie / freePlaces) * 100;
            Console.WriteLine($"{nameOfMovie} - {percentMovie:F2}% full.");

            nameOfMovie = Console.ReadLine();
            counterMovie = 0;
            counterStudentOne = 0;
            counterStandartOne = 0;
            counterKidOne = 0;
        }

        totalTikets = counterStudentTwo + counterStandartTwo + counterKidTwo;
        Console.WriteLine($"Total tickets: {totalTikets}");

        percentStudentTikets = (counterStudentTwo / totalTikets) * 100;
        Console.WriteLine($"{percentStudentTikets:F2}% student tickets.");

        percentStandartTikets = (counterStandartTwo / totalTikets) * 100;
        Console.WriteLine($"{percentStandartTikets:F2}% standard tickets.");

        percentKidTikets = (counterKidTwo / totalTikets) * 100;
        Console.WriteLine($"{percentKidTikets:F2}% kids tickets.");
    }
}
