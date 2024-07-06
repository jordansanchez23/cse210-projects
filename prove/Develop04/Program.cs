// I made this exceeding requirement: Make sure no random prompts/questions are selected until they have all been used at least once in that session.

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.Write("Select a choice from the menu");
            string choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
            {
                activity = new BreathingActivity();
            }

            else if (choice == "2")
            {
                activity = new ReflectingActivity();
            }

            else if (choice == "3")
            {
                activity = new ListingActivity();
            }

            else if (choice == "4")
            {
                Console.WriteLine("Goodbye");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again");
            }

        
            activity.DisplayStartingMessage();
            activity.Run();
            activity.DisplayEndingMessage();
            
        }
    }
}
















