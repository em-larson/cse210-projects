using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";

        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program! Please choose from the menu below:");
            Console.WriteLine("");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");

            choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }

            if (choice == "2")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }

            if (choice == "3")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
        }

    }
}