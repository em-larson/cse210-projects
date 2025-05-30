using System;

//The extra mile part of this assignment, allows you to input any scripture that you would like to work on memorizing into the program first.
//(This would technically act as the first step of memorizing it. Reading and typing it all the way through.)

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer. ");
        Console.WriteLine("Do you have multiple verses or a single verse? (input 1 or 2)");
        Console.WriteLine("1. Single");
        Console.WriteLine("2. Multiple");

        int answer = int.Parse(Console.ReadLine());

        if (answer != 1 && answer != 2)
        {
            return;
        }

        Console.Write("What is the scripture book? ");
        string book = Console.ReadLine();
        Console.Write("What is the chapter? ");
        int chapter = int.Parse(Console.ReadLine());
        Console.Write("What is the verse? ");
        int verse = int.Parse(Console.ReadLine());

        Reference reference;

        if (answer == 1)
        {
            reference = new Reference(book, chapter, verse);
        }
        else
        {
            Console.Write("What is the last verse? ");
            int endVerse = int.Parse(Console.ReadLine());

            reference = new Reference(book, chapter, verse, endVerse);
        }

        Console.WriteLine("Please type in the text of the verse that you would like to memorize: ");
        string input = Console.ReadLine();
        Scripture scripture = new Scripture(reference, input);

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press enter to continue or type 'quit to finish:");
            string result = Console.ReadLine();
            if (result == "quit")
            {
                break;
            }

            else
            {
                if (scripture.IsCompletelyHidden() == true)
                {
                    break;
                }

                scripture.HideRandomWords(3);
            }
        }

    }
}