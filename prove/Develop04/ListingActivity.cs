using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public new void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Starting listing activity...");
        Random rand = new Random();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Thread.Sleep(2000); 
        
        Console.WriteLine("Start listing items:");
        List<string> items = GetListFromUser(10);
        Console.WriteLine($"Number of items listed: {items.Count}");

        //for (int i = 1; i <= _duration; i++)
        //{
        //    Console.WriteLine($"Item {i}: ________");
        //    Thread.Sleep(1000); 
        //}
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> items = new List<string>();
        //Console.WriteLine("Start listing items:");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            items.Add(item);
        }
        return items;
    }
}