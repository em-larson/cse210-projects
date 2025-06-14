public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string DisplayName()
    {
        return _name;
    }


    public virtual string GetDetails()
    {
        if (IsComplete() == true)
        {
            return $"[x] {_name}: {_description}";
        }

        else
        {
            return $"[ ] {_name}: {_description}";
        }
    }

    public virtual int ReturnPoints()
    {
        int points = int.Parse(_points);
        return points;
    }

    public abstract string GetStringRepresentation();


}