public class Running : Workout
{
    private float _distance;

    public Running(int time, float distance) : base(time)
    {
        _type = "Running";
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return _distance / (_time / 60f);
    }

    public override float GetPace()
    {
        return _time / _distance;
    }
}