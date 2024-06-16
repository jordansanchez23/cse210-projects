using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string inputGrade = Console.ReadLine();
        int grade = int.Parse(inputGrade);

        string letter = "";

        if (grade >= 90 )
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";;
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed");
        }

        else
        {
            Console.WriteLine("You didn't pass, please keep up");
        }
    }
}