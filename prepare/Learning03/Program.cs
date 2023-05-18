using System;

class Program
{
    static void Main(string[] args)
    {
        int _numerator;
        int _denominator;
        Console.WriteLine("Please enter the numerator");
        _numerator = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the denominator");
        _denominator = int.Parse(Console.ReadLine());

        Fraction fraction = new Fraction(_numerator, _denominator);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

    }
}