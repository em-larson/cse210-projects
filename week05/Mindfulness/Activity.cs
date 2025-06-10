public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 60;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long would you like your session to be, in seconds?");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done. You have completed your Mindfulness Activity.");
        Console.WriteLine();
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds = seconds - 1;
            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds = seconds - 1;
            Console.Write("-");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds = seconds - 1;
            Console.Write("\\");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds = seconds - 1;
        }
    }

    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds = seconds - 1;
        }
    }
}