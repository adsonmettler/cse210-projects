using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        // Author: Adson Mettler do Nascimento
        // Guessing game

        // Part 1 and Part 2
        // Console.Write("What is the magic number? ");
        // string numberFromUser = Console.ReadLine();

        // int magicNumber = int.Parse(numberFromUser);

        // Part 3
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guessNumber = 0;

        while (guessNumber != magicNumber)

        {
            Console.Write("What is your guess? ");
            string guessFromUser = Console.ReadLine();

            guessNumber = int.Parse(guessFromUser);

            if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber == guessNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}