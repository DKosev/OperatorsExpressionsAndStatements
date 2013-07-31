//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class CheckTheThirdDigit
{
    static void Main()
    {
        int thirdDigitValue = 7;
        Console.Write("Enter a number to check if it's third digit is {0}: (right-to-left)\n=> ", thirdDigitValue);
        int inputValue = int.Parse(Console.ReadLine());
        bool checkThirdDigit = (inputValue / 100) % 10 == thirdDigitValue;
        if (checkThirdDigit == true)
            Console.WriteLine("The entered number {0} have {1} as a third digit.. right-to-left", inputValue, thirdDigitValue);
        else
            Console.WriteLine("The entered number {0} doesn't have {1} as a third digit.. right-to-left", inputValue, thirdDigitValue);
    }
}
