//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class FindingBit
{
    static void Main()
    {
        Console.Write("Enter a value:\n=> ");
        int inputValue = int.Parse(Console.ReadLine());
        int bit = 3;
        int mask = 1 << bit;
        Console.Write("The bit {0} of the integer {1} is:\n=> ", bit, inputValue);
        Console.WriteLine((inputValue & mask) != 0 ? 1 : 0);
    }
}
