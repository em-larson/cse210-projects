using System.ComponentModel.DataAnnotations.Schema;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Congrats!! You did it!");
        Console.WriteLine();
        _isComplete = true;
    }

    public void SetIsComplete(string complete)
    {
        if (complete == "true")
        {
            _isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"simple|{_points}|{_name}|{_description}|{_isComplete}";
    }
}