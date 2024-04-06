using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    protected List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    protected List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public new void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Random rand = new Random();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Thread.Sleep(2000); 
        foreach (string question in _questions)
        {
            Console.WriteLine($"{question}");
            Thread.Sleep(4000);
            ShowSpinner(3); 
        }
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"{prompt}");
    }

    public void DisplayQuestion(string question)
    {
        Console.WriteLine($"{question}");
    }
}