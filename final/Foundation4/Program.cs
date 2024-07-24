using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 7, 20), 30, 3.0),
            new Cycling(new DateTime(2024, 7, 21), 45, 15.0),
            new Swimming(new DateTime(2024, 7, 22), 60, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}