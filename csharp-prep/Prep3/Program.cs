using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else 
            {
                Console.WriteLine("You guessed it");
            }
    
        }

    }
}