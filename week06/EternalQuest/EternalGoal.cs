public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine("Congrats!! You did it!");
        Console.WriteLine();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"eternal|{_points}|{_name}|{_description}";
    }
}