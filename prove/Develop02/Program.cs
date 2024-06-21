// I added the question of location when the user answers the prompt
//This location is store wit the rest of the data

using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool Quit = false;
        while (!Quit)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string date = DateTime.Now.ToShortDateString();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Response: ");
                string entryText = Console.ReadLine();
                Console.Write("Location/Context (home, office, school): ");
                string location = Console.ReadLine();
                Entry newEntry = new Entry(date, prompt, entryText, location);
                myJournal.AddEntry(newEntry);
            }

            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter the name of the filename you want to load as journal: ");
                string loadFilename = Console.ReadLine();
                myJournal.LoadFromFile(loadFilename);
            }

            else if (choice == "4")
            {
                
                Console.Write("Enter the filename to save the journal: ");
                string saveFilename = Console.ReadLine();
                myJournal.SaveToFile(saveFilename);
            }

            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
}