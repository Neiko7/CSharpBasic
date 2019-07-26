using System;


class Scholarship
{
    static void Main()
    {
        double income = double.Parse(Console.ReadLine());
        double averageSuccess = double.Parse(Console.ReadLine());
        double minimalSalary = double.Parse(Console.ReadLine());

        double excellentSuccess = 5.5;
        double goodSuccess = 4.5;
        double socialScholarship = Math.Floor(minimalSalary * 0.35);
        double scholarshipForExcellentSuccess = Math.Floor(averageSuccess * 25);

        if (income < minimalSalary && averageSuccess > goodSuccess)
        {
            if (averageSuccess < excellentSuccess)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", socialScholarship);
            }
            else if (averageSuccess >= excellentSuccess)
            {
                if (scholarshipForExcellentSuccess >= socialScholarship)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", scholarshipForExcellentSuccess);
                }
                else
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", socialScholarship);
                }
            }
        }
        else if (averageSuccess >= excellentSuccess)
        {
            Console.WriteLine("You get a scholarship for excellent results {0} BGN", scholarshipForExcellentSuccess);
        }
        else
        {
            Console.WriteLine("You cannot get a scholarship!");
        }
    }
}

