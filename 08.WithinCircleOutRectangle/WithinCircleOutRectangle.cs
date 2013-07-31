//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class WithinCircleOutRectangle
{
    static void Main()
    {
        //Will use int, but it's better to use decimal!
        
        //Check the X and Y points, if they are witing the circle:
        Console.Write("Enter the value for point X:\n=> ");
        int pointX = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for point Y:\n=> ");
        int pointY = int.Parse(Console.ReadLine());
        int circlePoint = 1;
        int result = ((pointX - circlePoint) * (pointX - circlePoint)) + ((pointY - circlePoint) * (pointY - circlePoint));
        int radius = 5;
        bool checkCircle = result < radius * radius;

        //Check if the X and Y points are outside of the rectangle:
        int top = 1;
        int left = -1;
        int width = 6;
        int height = 2;
        bool checkRectangle = pointY > top && pointY < (top + height) && pointX > left && pointX < (left + width);

        if (checkCircle && checkRectangle == true)
        {
            Console.WriteLine("The point is within the circle and outside of the rectangle!");
        }
        else
        {
            Console.WriteLine("The point is outside of the circle or within the rectangle!");
        }
    }
}