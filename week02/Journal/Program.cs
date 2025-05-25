using System;

class Program
{
    public static Journal journal = new Journal();
    public static PromptGenerator promptGenerator = new PromptGenerator();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Journaling made Easy!");

        while (true)
        {
            string input = GetInput();
            int num = int.Parse(input);

            if (num == 1)
            {
                AddNewEntry();
            }
            else if (num == 2)
            {
                journal.DisplayAll();
            }
            else if (num == 3)
            {
                journal.SaveToFile("Journal.txt");
            }
            else if (num == 4)
            {
                journal.LoadFromFile("Journal.txt");
            }
            else
            {
                break;
            }
        }
    }

    static string GetInput()
    {
        Console.WriteLine("Please choose from the options below and enter the cooresponding number.");
        Console.WriteLine("1. Add a new Entry");
        Console.WriteLine("2. Display all enteries");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Quit Program");
        return Console.ReadLine();
    }
    static void AddNewEntry()
    {
        string date = System.DateTime.Now.ToString("dd.MM.yyyy");
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Please type your answer below:");
        string entry = Console.ReadLine();

        Entry _newEntry = new Entry()
        {
            _date = date,
            _promptText = prompt,
            _entryText = entry,
        };

        journal.AddEntry(_newEntry);
    }
}