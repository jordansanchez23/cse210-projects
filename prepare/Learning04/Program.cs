using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment();
        assignment.SetStudentName("Samuel Bennett");
        assignment.SetTopic("Multiplication");

        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Jordan Sanchez", "Decimals", "7.3", "8-19");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Jordan Sanchez", "European History", "The Causes of World War II");

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }


}