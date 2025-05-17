using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (Please enter just the numbers) ");
        string stringpercent = Console.ReadLine();
        int percent = int.Parse(stringpercent);
        string letter = "";

        if (percent < 60)
        {
            // Console.WriteLine("Your grade is an F");
            letter = "F";
        }

        else if (percent < 70)
        {
            // Console.WriteLine("Your grade is an D");
            letter = "D";
        }

        else if (percent < 80)
        {
            // Console.WriteLine("Your grade is a C");
            letter = "C";
        }

        else if (percent < 90)
        {
            // Console.WriteLine("Your grade is a B");
            letter = "B";
        }

        else
        {
            // Console.WriteLine("Your grade is an A!");
            letter = "A";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You are passing the class!");
        }
        else
        {
            Console.WriteLine("You are not currently passing the class. Lets meet with your professor and see what options are available.");
        }

    }
}