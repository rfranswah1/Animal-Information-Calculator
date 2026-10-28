using System;

class Program
{
    static void Main()
    {
        // -- Animal Information Entry --
        Console.WriteLine("--Animal Information Entry--");
        
        // 1. Prompt and read the animal name (string)
        Console.Write("Enter animal name: Dog ");
        string animalName = Console.ReadLine();

        // 2. Prompt and read the count of animals (int)
        Console.Write($"Enter number of {animalName}'s: ");
        int animalCount = Convert.ToInt32(Console.ReadLine());

        // 3. Prompt and read the food amount (double)
        Console.Write($"Enter pounds of food per {animalName} per day: ");
        double foodPerDayPerAnimal = Convert.ToDouble(Console.ReadLine());

        // -- Calculations --
        // Calculate the total daily food for all of these animals
        double totalDailyFood = animalCount * foodPerDayPerAnimal;
        
        // Calculate the weekly food requirement (daily x 7)
        double totalWeeklyFood = totalDailyFood * 7;

        // -- Animal Summary Output --
        Console.WriteLine("\n--Animal Summary--");
        Console.WriteLine($"Animal: {animalName}");
        Console.WriteLine($"Count: {animalCount}");
        Console.WriteLine($"Food per animal: {foodPerDayPerAnimal} lbs/day");
        Console.WriteLine($"Total daily food: {totalDailyFood} lbs");
        Console.WriteLine($"Total weekly food: {totalWeeklyFood} lbs");
    }
}
