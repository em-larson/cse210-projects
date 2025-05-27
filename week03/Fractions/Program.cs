using System;
using System.Runtime.Intrinsics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();

        Fraction f2 = new Fraction(5);

        Fraction f3 = new Fraction(2, 3);

        int v1 = f1.GetTop();
        Console.WriteLine(v1);

        int v2 = f3.GetBottom();
        Console.WriteLine(v2);

        f1.SetTop(7);

        f2.SetBottom(2);

        int v3 = f1.GetTop();
        Console.WriteLine(v3);

        int v4 = f2.GetBottom();
        Console.WriteLine(v4);

        string v5 = f3.GetFractionString();
        Console.WriteLine(v5);

        double v6 = f2.GetDecimalValue();
        Console.WriteLine(v6);
    }
}