//GoalManager class manages goals and visualizes progress using a simple bar.
//Progress is shown after recording events, reflecting the user's score towards goals

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}