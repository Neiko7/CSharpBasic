using System;


class Personal_Titles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();

        int teenage = 16;

        if (gender == "m")
        {
            if (age >= teenage)
            {
                Console.WriteLine("Mr.");
            }
            else
            {
                Console.WriteLine("Master");
            }
        }
        else
        {
            if (age >= teenage)
            {
                Console.WriteLine("Ms.");
            }
            else
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
