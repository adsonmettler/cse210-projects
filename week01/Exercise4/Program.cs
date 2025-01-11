using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Author: Adson Mettler do Nascimento
        // List generator and calculator

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number == 0)
                {
                    break;
                }
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Calculations
        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Count;
            int largest = int.MinValue;

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine($"\nThe sum is: {sum}");
            Console.WriteLine($"The average is: {average:F2}");
            Console.WriteLine($"The largest number is: {largest}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}