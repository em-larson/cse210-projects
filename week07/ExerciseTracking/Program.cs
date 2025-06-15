using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running(30, 3.2f);

        Cycling bike = new Cycling(56, 18.0f);

        Swimming swim = new Swimming(45, 50);

        List<Workout> workouts = new List<Workout>();

        workouts.Add(run);
        workouts.Add(bike);
        workouts.Add(swim);

        foreach (Workout workout in workouts)
        {
            Console.WriteLine(workout.GetSummary());
        }
    }
}