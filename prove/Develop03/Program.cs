using System;


class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("Joshua", 1, 9, "This passage encourages Joshua to be strong and courageous as he leads the Israelites to the promised land. God promises to be with him wherever he goes, providing guidance and support.");
        string scriptureText = "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest";

        Scripture scripture = new Scripture(reference, scriptureText);

        

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");

        while (true)
        {
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
            {
                break;
            }

            int numberToHide = 3; 
            scripture.HideRandomWords(numberToHide);

            Console.Clear(); 
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Press enter to finish or type 'quit'.");
                Console.ReadLine(); 
                break; 
            }
            else
            {
                Console.WriteLine("Press enter to continue hiding words or type 'quit' to finish.");
            }
        }

        Console.WriteLine("Program finished. Press any key to exit.");
        Console.ReadKey(); 
    }
}