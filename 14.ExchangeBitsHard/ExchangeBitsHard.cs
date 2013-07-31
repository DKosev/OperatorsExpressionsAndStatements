//* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class ExchangeBitsHard
{
    static void Main()
    {
        Console.Write("Enter the number:\n=> ");
        int inputValue = int.Parse(Console.ReadLine());
        Console.Write("Enter the 'p' value:\n=> ");
        int pValue = int.Parse(Console.ReadLine());
        Console.Write("Enter the 'k' value:\n=> ");
        int kValue = int.Parse(Console.ReadLine());
        Console.Write("Enter the 'q' value:\n=> ");
        int qValue = int.Parse(Console.ReadLine());
        Console.Write("Choose which bits you want to exchange (option 1 or 2 or 3):\n1. First option: {0} & {1}\n2. Second option: ({0} + 1) & ({1} + 1)\n3. Third option: ({0} + {2} - 1) & ({1} + {2} - 1)\n=> ", pValue, qValue, kValue);
        int userChoice = int.Parse(Console.ReadLine());
        if (userChoice == 1)
        {
            int maskForP = 7 << pValue;
            int maskForQ = 7 << qValue;
            int firstMask = maskForP ^ maskForQ;
            int maskAndInput = firstMask & inputValue;
            int toBitQ = (maskAndInput >> pValue) << qValue;
            int toBitP = (maskAndInput >> qValue) << pValue;
            int secondMask = (~firstMask) & inputValue;
            int theNewNumber = secondMask | (toBitP ^ toBitQ);

            Console.WriteLine("{0} - Your entered number", Convert.ToString(inputValue, 2).PadLeft(32, '0'));
            Console.WriteLine("{0} - The masked number", Convert.ToString(firstMask, 2).PadLeft(32, '0'));
            Console.WriteLine("{0} - The result after the exchange", Convert.ToString(theNewNumber, 2).PadLeft(32, '0'));
        }
        else if (userChoice == 2)
        {
            int inputP = pValue + 1;
            int inputQ = qValue + 1;
            int maskForP = 7 << inputP;
            int maskForQ = 7 << inputQ;
            int firstMask = maskForP ^ maskForQ;
            int maskAndInput = firstMask & inputValue;
            int toBitQ = (maskAndInput >> inputP) << inputQ;
            int toBitP = (maskAndInput >> inputQ) << inputP;
            int secondMask = (~firstMask) & inputValue;
            int theNewNumber = secondMask | (toBitP ^ toBitQ);

            Console.WriteLine("{0} - Your entered number", Convert.ToString(inputValue, 2).PadLeft(32, '0'));
            Console.WriteLine("{0} - The masked number", Convert.ToString(firstMask, 2).PadLeft(32, '0'));
            Console.WriteLine("{0} - The result after the exchange", Convert.ToString(theNewNumber, 2).PadLeft(32, '0'));
        }
        else if (userChoice == 3)
        {
            int inputP = (pValue + kValue) - 1;
            int inputQ = (qValue + kValue) - 1;
            int maskForP = 7 << inputP;
            int maskForQ = 7 << inputQ;
            int firstMask = maskForP ^ maskForQ;
            int maskAndInput = firstMask & inputValue;
            int toBitQ = (maskAndInput >> inputP) << inputQ;
            int toBitP = (maskAndInput >> inputQ) << inputP;
            int secondMask = (~firstMask) & inputValue;
            int theNewNumber = secondMask | (toBitP ^ toBitQ);

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
