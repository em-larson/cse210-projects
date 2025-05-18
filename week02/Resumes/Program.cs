using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Davis School District";
        job1._endYear = 2025;
        job1._jobTitle = "Physics Teacher";
        job1._startYear = 2021;

        Job job2 = new Job();
        job2._company = "Utah State University";
        job2._startYear = 2016;
        job2._endYear = 2020;
        job2._jobTitle = "Undergraduate Teaching Fellow";


        //job1.Display();
        //job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Emily Larson";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}