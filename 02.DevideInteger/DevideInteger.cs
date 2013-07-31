//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DevideInteger
{
    static void Main()
    {
        Console.Write("Enter the number that you want to divide by two values:\n=> ");
        int inputValue = int.Parse(Console.ReadLine());
        Console.Write("Enter the first divide value:\n=> ");
        int firstDivideValue = int.Parse(Console.ReadLine());
        Console.Write("Enter the second divide value:\n=> ");
        int secondDivideValue = int.Parse(Console.ReadLine());

        bool firstDevideResult = inputValue % firstDivideValue == 0;
        bool secondDevideResult = inputValue % secondDivideValue == 0;
        bool checkedValue = firstDevideResult && secondDevideResult;
        if (checkedValue == true)
            Console.WriteLine("The entered number \"{0}\" can be divided by \"{1}\" and \"{2}\"!", inputValue, firstDivideValue, secondDivideValue);
        else
            Console.WriteLine("You can't divide \"{0}\" by \"{1}\" and \"{2}\"!", inputValue, firstDivideValue, secondDivideValue);
    }
}
