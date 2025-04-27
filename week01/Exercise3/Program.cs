using System;
using System.Formats.Asn1;
using System.Runtime.ConstrainedExecution;
using System.Security.Authentication.ExtendedProtection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        
        int guess = -1;

        while (guess != number)
        {
            Console.WriteLine("Guess again. ");
            string next = Console.ReadLine();
            guess = int.Parse(next);

            if (number > guess)
            {
                Console.WriteLine("higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            
            }
            else 
            {
                Console.WriteLine("You got it!");
            }
        }


    }
}