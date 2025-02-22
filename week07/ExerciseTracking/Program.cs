using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>
        {
            new Running(5, "Running", 30, "2025/10/10"),
            new Swimming(30, "Swimming", 30, "2025/10/10"),
            new Cycling(20, "Cycling", 30, "2025/10/10"),
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}