using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Harry Potter", "Divination: tea Leaves");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Hermione Granger", "Arithmancy", "Section 7", "12-25 odd");
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine(assignment2.GetSummary());

        WritingAssignment assignment3 = new WritingAssignment("Ron Weasly", "Quidditch", "Why I Should be a Keeper");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}