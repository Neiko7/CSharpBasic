using System;


class Trekking_Mania
{
    static void Main()
    {
        int numberOfGroups = int.Parse(Console.ReadLine());

        int groups = 0;

        int counterMusala = 0;
        int counterMontBlanc = 0;
        int counterKilimanjaro = 0;
        int counterK2 = 0;
        int counterEverest = 0;

        for (int i = 1; i <= numberOfGroups; i++)
        {
            groups = int.Parse(Console.ReadLine());

            if (groups <= 5)
            {
                counterMusala += groups;
            }
            else if (groups <= 12)
            {
                counterMontBlanc += groups;
            }
            else if (groups <= 25)
            {
                counterKilimanjaro += groups;
            }
            else if (groups <= 40)
            {
                counterK2 += groups;
            }
            else if (groups > 40)
            {
                counterEverest += groups;
            }
        }

        double sumPeople = counterMusala + counterMontBlanc + counterKilimanjaro + counterK2 + counterEverest;

        double persentMusala = (counterMusala / sumPeople) * 100;
        double percentMontBlanc = (counterMontBlanc / sumPeople) * 100;
        double percentKilimanjaro = (counterKilimanjaro / sumPeople) * 100;
        double percentK2 = (counterK2 / sumPeople) * 100;
        double percentEverest = (counterEverest / sumPeople) * 100;

        Console.WriteLine($"{persentMusala:F2}%");
        Console.WriteLine($"{percentMontBlanc:F2}%");
        Console.WriteLine($"{percentKilimanjaro:F2}%");
        Console.WriteLine($"{percentK2:F2}%");
        Console.WriteLine($"{percentEverest:F2}%");
    }
}
