//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter the value for 'b1' side:\n=> ");
        int b1Side = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for 'b2' side:\n=> ");
        int b2Side = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for the height:\n=> ");
        int height = int.Parse(Console.ReadLine());
        int result = ((b1Side + b2Side) / 2) * height;
        Console.WriteLine("The area of the trapezoid with b1 = {0}, b2 = {1} and h = {2} is: {3}", b1Side, b2Side, height, result);
    }
}