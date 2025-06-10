using System.Runtime.CompilerServices;


public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity allows you to list all of the good things in your life in a certain area. List as many answers as you can think of to the given question.";
        _count = 0;
        _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours? ", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heros?", "What are things that you do well?", "What is a quote/book/song that uplifted you recently?"];
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine("Ponder the prompt below. When you are ready to begin listing, please hit enter.");
        Console.WriteLine();
        Console.WriteLine(_prompts[index]);
        string input = Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (true)
        {
            DateTime checkTime = DateTime.Now;
            if (checkTime > endTime)
            {
                break;
            }
            Console.Write(">>");
            string item = Console.ReadLine();
            _count = _count + 1;

        }
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();

    }
}