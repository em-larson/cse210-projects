using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (true)
        {
            Console.Write("Enter Number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        int sum = 0;
        int greatestNumber = 0;
        foreach (int numb in numbers)
        {
            sum += numb;
            if (numb > greatestNumber)
            {
                greatestNumber = numb;
            }
        }
        float average = sum / numbers.Count;

        Console.WriteLine($"The sum is : {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {greatestNumber}");
    }
}