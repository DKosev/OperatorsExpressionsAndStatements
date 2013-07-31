//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

using System;

class BitPosition
{
    static void Main()
    {
        Console.Write("Enter your number:\n=> ");
        int inputValue = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit:\n=> ");
        int bitPosition = int.Parse(Console.ReadLine());
        int bitZeroOrOne = 1;
        int mask = bitZeroOrOne << bitPosition;
        bool checkTheBit = (inputValue & mask) != 0;
        if (checkTheBit == true)
            Console.WriteLine("The bit is {0}, so we have a True result!", bitZeroOrOne);
        else
            Console.WriteLine("The bit is different than {0}, so we have a False result!", bitZeroOrOne);
    }
}
