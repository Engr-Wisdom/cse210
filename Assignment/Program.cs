using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create activities
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 4.8),
            new Cycling("03 Nov 2022", 45, 25.0),
            new Swimming("03 Nov 2022", 20, 30)
        };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}