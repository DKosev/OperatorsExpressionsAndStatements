//Write an expression that calculates rectangle’s area by given width and height.

using System;

class CalculateRectanglesArea
{
    static void Main()
    {
        Console.WriteLine(@"
                   ''''''''''''''''''''''''''''
                   '                          '
                   '                          '  b
                   '                          '
                   ''''''''''''''''''''''''''''
                                a
             S = a * b
        ");
        Console.Write("Enter the value for the \"a\" side of the rectangle:\n=> ");
        int aSide = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for the \"b\" side of the rectangle:\n=> ");
        int bSide = int.Parse(Console.ReadLine());
        int result = aSide * bSide;
        Console.WriteLine("Using the formula S = {0} * {1}", aSide, bSide);
        Console.WriteLine("The result is: S = {0}", result);
    }
}
