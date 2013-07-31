//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class PointInACircle
{
    static void Main()
    {
        //Will use int, but it's better to use decimal!
        Console.Write("Enter the value for the point X:\n=> ");
        int pointX = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for the point Y:\n=> ");
        int pointY = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for the point X of the circle:\n=> ");
        int circleX = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for the point Y of the circle:\n=> ");
        int circleY = int.Parse(Console.ReadLine());
        int result = ((pointX - circleX) * (pointX - circleX)) + ((pointY - circleY) * (pointY - circleY));
        int radius = 5;
        bool checkPoints = result < radius * radius;
        if (checkPoints == true)
            Console.WriteLine("Given points are within the circle!");
        else
            Console.WriteLine("Given points are outside of the circle!");
    }
}
