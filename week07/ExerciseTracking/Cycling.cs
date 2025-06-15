public class Cycling : Workout
{
    private float _speed;

    public Cycling(int time, float speed) : base(time)
    {
        _type = "Cycling";
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed * (_time / 60f);
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return _time / GetDistance();
    }
}