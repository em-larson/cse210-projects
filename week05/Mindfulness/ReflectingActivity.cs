using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have chosen kindness or resiliance. This will help you see the power you have in your life";
        _prompts = ["Think of a time when you stood up for someone else", "Think of a time when you accomplished something difficult", "Think of a time when you helped someone in need", "Think of a time when you showed kindness to yourself", "Think of a time when you did something selfless", "Think of a time when you gave something up for something/someone greater", "Think of a time when you felt like giving up but didn't"];
        _questions = ["Why was this experience meaningful to you", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete", "What is your favorite thing about this experience?", "What can you learn about this situation?", "What can you learn about yourself through this experience?"];
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine("When you have a moment in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.Write("Ponder on each of the questions as they pertain to the experience you have thought of. The questions will begin at the end of the countdown.");
        Console.WriteLine();
        ShowCountDown(5);
        Console.WriteLine();
        int count = 0;
        while (count < _duration)
        {
            DisplayQuestions();
            ShowSpinner(8);
            count = count + 8;
        }
        Console.WriteLine();
        DisplayEndingMessage();


    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

}