using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");


        List<int> numbers = new List<int>();

        int user = -1;
        
        while (user != 0)
        {
            Console.Write("Enter a number or (0) to quit. ");

            string answer = Console.ReadLine();
            user = int.Parse(answer);

            if (user != 0)
            {
                numbers.Add(user);
            }
        }
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}.");


        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {avg}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is {max}.");
    }
}