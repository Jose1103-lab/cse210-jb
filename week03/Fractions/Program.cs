using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.\n\n");

        Fraction fraction = new Fraction(1 , 5);

        // fraction.SetTop(15);
        // fraction.SetBottom(10);
        Console.WriteLine(fraction.GetDecimalValue() + "\n" + fraction.GetFractionString());

 
    }
}