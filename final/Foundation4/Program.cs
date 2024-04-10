using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 4, 5), 15, 5.0),
            new Cycling(new DateTime(2024, 3, 31), 30, 15.0),
            new Swimming(new DateTime(2024, 4, 9), 25, 10)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}