public abstract class Workout
{
    private string _date;

    protected int _time;

    protected string _type;

    public Workout(int time)
    {
        _date = DateTime.Now.ToString("M/d/yyyy");
        _time = time;
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();
    public abstract float GetPace();

    public string GetSummary()
    {
        float distance = (float)Math.Round(GetDistance(), 2);
        float speed = (float)Math.Round(GetSpeed(), 2);
        float pace = (float)Math.Round(GetPace(), 2);
        return ($"{_date} {_type} ({_time} min) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile");
    }
}