using System.Threading.Tasks.Dataflow;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void start()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. Display Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Events");
        Console.WriteLine("6. Quit");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}.");
    }

    public void ListGoalNames()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.DisplayName()}");
            index = index + 1;
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDetails());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to make? choose from the options below:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine();
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("What would you like to name your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("Briefly describe your goal");
        string describe = Console.ReadLine();

        Console.WriteLine("How many points do you want associated with this goal? (points are awarded each time you accomplish an event)");
        string points = Console.ReadLine();

        if (choice == 1)
        {
            SimpleGoal g = new SimpleGoal(name, describe, points);
            _goals.Add(g);
        }

        if (choice == 2)
        {
            EternalGoal g = new EternalGoal(name, describe, points);
            _goals.Add(g);
        }

        if (choice == 3)
        {
            Console.WriteLine("How many times would like to accomplish this goal?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What do you want your bonus to be when the goal is completely accomplished?");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal g = new ChecklistGoal(name, describe, points, target, bonus);
            _goals.Add(g);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("What goal would you like to record an event about? pick from the list below.");
        int i = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}.{g.GetDetails()}");
            i = i + 1;
        }
        Console.WriteLine();


        int x = int.Parse(Console.ReadLine());
        Goal h = _goals[x - 1];
        h.RecordEvent();

        _score = _score + h.ReturnPoints();
    }

    public void SaveGoals()
    {
        string filename = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        string filename = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {


            string[] parts = line.Split("|");
            string i = parts[0];
            string points = parts[1];
            string name = parts[2];
            string description = parts[3];

            if (i == "simple")
            {
                string complete = parts[4];
                SimpleGoal goal = new SimpleGoal(name, description, points);
                goal.SetIsComplete(complete);
                _goals.Add(goal);
            }

            if (i == "eternal")
            {
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }

            if (i == "checklist")
            {
                int complete = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                goal.SetAmountComplete(complete);
                _goals.Add(goal);
            }


        }
    }
}