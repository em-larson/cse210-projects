public class BreathingActivity : Activity
{

    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity focuses on taking slow and deliberate breathes. Clear your mind and focus on trying to match the pacing of the breathes.";
    }
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        name = "Breathing Activity";
        description = "This activity focuses on taking slow and deliberate breathes. Clear your mind and focus on trying to match the pacing of the breathes.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        int count = 0;
        while (count < _duration)
        {
            Console.Write("Breathe In...");
            ShowCountDown(5);
            count = count + 5;
            Console.WriteLine();
            Console.Write("Breathe Out...");
            ShowCountDown(5);
            count = count + 5;
            Console.WriteLine();
        }
    }
}