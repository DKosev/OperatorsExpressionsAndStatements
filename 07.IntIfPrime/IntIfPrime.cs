//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class IntIfPrime
{
    static void Main()
    {
        Console.Write("Enter a number between 1 - 100 to check if it's prime:\n=> ");
        int inputValue = int.Parse(Console.ReadLine());
        int checker = 0;
        if (inputValue > 0 && inputValue <= 100)
        {
            for (int i = 2; i < inputValue; i++)
            {
                int result = (inputValue % i);
                if (result == 0)
                {
                    checker++;
                }
            }
            if (checker < 1)
               Console.WriteLine("The entered number {0} is Prime!\a", inputValue);
            else
               Console.WriteLine("The entered number {0} isn't Prime!\a", inputValue);
        }
        else 
            Console.WriteLine("You have to enter a value between 1 - 100!");
    }
}