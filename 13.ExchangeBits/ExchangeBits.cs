//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter the number:\n=> ");
        uint inputValue = uint.Parse(Console.ReadLine());
        Console.Write("Choose which bits you want to exchange (option 1 or 2 or 3):\n1. First option: 3 and 24\n2. Second option: 4 and 25\n3. Third option: 5 and 26\n=> ");
        int userChoice = int.Parse(Console.ReadLine());
        if (userChoice == 1)
        {
            uint maskFor3 = 7 << 3;
            uint maskFor24 = 7 << 24;
            uint firstMask = maskFor3 ^ maskFor24;
            uint maskAndInput = firstMask & inputValue;
            uint toBit24 = (maskAndInput >> 3) << 24;
            uint toBit3 = (maskAndInput >> 24) << 3;
            uint secondMask = (~firstMask) & inputValue;
            uint theNewNumber = secondMask | (toBit3 ^ toBit24);

            Console.WriteLine("{0} - Your entered number", Convert.ToString(inputValue, 2).PadLeft(32, '0'));
            Console.WriteLine("{0} - The masked number", Convert.ToString(firstMask, 2).PadLeft(32, '0'));
            Console.WriteLine("{0} - The result after the exchange", Convert.ToString(theNewNumber, 2).PadLeft(32, '0'));
        }
        else if (userChoice == 2)
        {
            uint maskFor4 = 7 << 4;
            uint maskFor25 = 7 << 25;
            uint firstMask = maskFor4 ^ maskFor25;
            uint maskAndInput = firstMask & inputValue;
            uint toBit25 = (maskAndInput >> 4) << 25;
            uint toBit4 = (maskAndInput >> 25) << 4;
            uint secondMask = (~firstMask) & inputValue;
            uint theNewNumber = secondMask | (toBit4 ^ toBit25);

            Console.WriteLine("{0} - Your entered number", Convert.ToString(inputValue, 2).PadLeft(32, '0'));
            Console.WriteLine("{0} - The masked number", Convert.ToString(firstMask, 2).PadLeft(32, '0'));
            Console.WriteLine("{0} - The result after the exchange", Convert.ToString(theNewNumber, 2).PadLeft(32, '0'));
        }
        else if (userChoice == 3)
        {
            uint maskFor5 = 7 << 5;
            uint maskFor26 = 7 << 26;
            uint firstMask = maskFor5 ^ maskFor26;
            uint maskAndInput = firstMask & inputValue;
            uint toBit26 = (maskAndInput >> 5) << 26;
            uint toBit5 = (maskAndInput >> 26) << 5;
            uint secondMask = (~firstMask) & inputValue;
            uint theNewNumber = secondMask | (toBit5 ^ toBit26);

            Console.WriteLine("{0} - Your entered number", Convert.ToString(inputValue, 2).PadLeft(32, '0'));
            Console.WriteLine("{0} - The masked number", Convert.ToString(firstMask, 2).PadLeft(32, '0'));
            Console.WriteLine("{0} - The result after the exchange", Convert.ToString(theNewNumber, 2).PadLeft(32, '0'));
        }
        else if (userChoice > 3)
        {
            Console.WriteLine("Wrong value, you have to choose 1, 2 or 3!");
        }   
    }
}
