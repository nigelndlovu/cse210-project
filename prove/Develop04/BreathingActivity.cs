using System;
using System.Collections.Generic;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    
    public new void Run()
    {
        DisplayStartingMessage();
        //Console.WriteLine("Starting breathing exercise...");
        for (int i = 0; i < _duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(000);
            Console.WriteLine("Now breathe out...");
            Thread.Sleep(5000);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}