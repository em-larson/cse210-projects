using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        // Console.WriteLine("What is the magic number? ");
        // string magicNumberString = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumberString);
        int guess = -1;

        do
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }


            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}