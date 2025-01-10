using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        // Author: Adson Mettler do Nascimento
        // Calculates user grade, give related letter and say if user has passed or not.
        Console.Write("Enter your grade (only numbers): ");
        string valueFromUser = Console.ReadLine();

        int grade = int.Parse(valueFromUser);

        string letter = "";

        if (grade >= 90)
        {
            letter = "C";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your final grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you have passed on the couser!");
        }
        else
        {
            Console.WriteLine("I'm sorry, you haven't passed on the couser. Keep working for next time!");
        }

    }
}