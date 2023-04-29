using Guess_the_number.Classes;
using System;

namespace Guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("--------------------------------");
                Console.Write("Guess tne number (1 - 10): ");
                var number = Console.ReadLine();
                Console.WriteLine();

                NumberClass numberClass = new NumberClass(Convert.ToInt32(number));
                var randomNumber = numberClass.Number();


                if (randomNumber > Convert.ToInt32(number))
                {
                    Console.WriteLine($"I didn't guess, the hidden number {randomNumber} is greater {number}");
                }
                else if (randomNumber < Convert.ToInt32(number))
                {
                    Console.WriteLine($"I did not guess, the hidden number {randomNumber} is less {number}");
                }
                else
                {
                    Console.WriteLine($"You guessed it - your numb {number}, random number {randomNumber}");
                }

                Console.WriteLine();
                Console.Write("You want continue? Yes/No: ");
                var answer = Console.ReadLine();
                if (answer.ToLower() == "no")
                {
                    break;
                }
            }
        }
    }
}
