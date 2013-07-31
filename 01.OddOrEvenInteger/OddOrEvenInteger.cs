//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenInteger
{
    static void Main()
    {
        Console.Write("Check if a number is Odd or Even:\n=> ");
        int value = int.Parse(Console.ReadLine());
        bool checkedValue = value % 2 == 0;
        if (checkedValue == true)
            Console.WriteLine("The number {0} is Even!", value);
        else
            Console.WriteLine("The number {0} is Odd!", value);
    }
}
