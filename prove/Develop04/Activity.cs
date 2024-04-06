using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        //_duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity:");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session?: ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> showSpinner = new List<string>();
        showSpinner.Add("|");
        showSpinner.Add("/");
        showSpinner.Add("-");
        showSpinner.Add("\\");
        showSpinner.Add("|");
        showSpinner.Add("/");
        showSpinner.Add("-");
        showSpinner.Add("\\");

        foreach (string s in showSpinner)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
    }

    public void Run()
    {

    }
}