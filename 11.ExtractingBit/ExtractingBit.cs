//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

using System;

class ExtractingBit
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