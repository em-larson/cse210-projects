public class Swimming : Workout
{
    private int _laps;

    public Swimming(int time, int laps) : base(time)
    {
        _laps = laps;
        _type = "Swimming";
    }

    public override float GetDistance()
    {
        return _laps * 50f / 1000f * 0.62f;
    }

    public override float GetSpeed()
    {
        return GetDistance() / (_time / 60f);
    }

    public override float GetPace()
    {
        return _time / GetDistance();
    }
}