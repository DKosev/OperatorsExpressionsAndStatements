//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class ModifyABit
{
    static void Main()
    {
        Console.Write("Enter your number:\n=> ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit:\n=> ");
        int bitPosition = int.Parse(Console.ReadLine());
        Console.Write("Enter the value for 'v':\n=> ");
        int vValue = int.Parse(Console.ReadLine());
        if (vValue == 0)
        {
            int mask = ~(1 << bitPosition);
            int checkTheBit = inputNumber & mask;
            Console.WriteLine("The number after the modification is:\n=> {0}", checkTheBit);
        }
        else if (vValue == 1)
        {
            int mask = 1 << bitPosition;
            int checkTheBit = inputNumber | mask;
            Console.WriteLine("The number after the modification is:\n=> {0}", checkTheBit);
        }
        else if ((vValue != 0) || (vValue != 1))
        {
            Console.WriteLine("Wrong 'v' value! You have to enter 1 or 0!");
        }
    }
}