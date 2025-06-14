using System.ComponentModel.DataAnnotations.Schema;

public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine();

        _amountComplete = _amountComplete + 1;
    }

    public override bool IsComplete()
    {
        if (_amountComplete >= _target)
        {
            return true;
        }

        return false;
    }

    public void SetAmountComplete(int complete)
    {
        _amountComplete = complete;
    }

    public override int ReturnPoints()
    {
        int points = int.Parse(_points);

        if (IsComplete())
        {
            if (_amountComplete == _target)
            {
                points += _bonus;
            }
            else
            {
                points = 0;
            }
        }

        return points;
    }

    public override string GetDetails()
    {
        if (IsComplete() == true)
        {
            return $"[x] {_name}: {_description} --{_amountComplete}/{_target} complete";
        }
        else
        {
            return $"[ ] {_name}: {_description} --{_amountComplete}/{_target} complete";

        }
    }

    public override string GetStringRepresentation()
    {
        return $"checklist|{_points}|{_name}|{_description}|{_amountComplete}|{_target}|{_bonus}";
    }
}