using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();

        while (true)
        {
            gm.start();
            Console.WriteLine();
            gm.DisplayPlayerInfo();
            Console.WriteLine();
            string menu = Console.ReadLine();
            Console.WriteLine();


            if (menu == "1")
            {
                gm.CreateGoal();
                Console.WriteLine();

            }

            if (menu == "2")
            {
                gm.ListGoalDetails();
                Console.WriteLine();

            }

            if (menu == "3")
            {
                Console.WriteLine("Saving...");

                gm.SaveGoals();

            }

            if (menu == "4")
            {
                Console.WriteLine("Loading...");
                gm.LoadGoals();
            }

            if (menu == "5")
            {
                gm.RecordEvent();
                Console.WriteLine();

            }

            if (menu == "6")
            {
                Console.WriteLine("If you exit without saving, all recorded data will be lost. Did you mean to exit? Press 0 to go back to the menu, any other key to continue.");
                string k = Console.ReadLine();
                if (k != "0")
                {
                    break;
                }
            }

        }
    }
}