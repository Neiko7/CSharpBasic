using System;


class Name_Wars 
{
    static void Main()
    {
        string name = Console.ReadLine();
        int maxValue = int.MinValue;
        string maxName = string.Empty;
        int currentName = 0;

        while (name != "STOP")
        {
              
            for (int i = 0; i < name.Length; i++)
            {
                currentName += name[i];

            }

            if (currentName > maxValue)
            {
                maxValue = currentName;
                maxName = name;
            }

            currentName = 0;
            name = Console.ReadLine();
        }

        Console.WriteLine($"Winner is {maxName} - {maxValue}!");
    }
}

