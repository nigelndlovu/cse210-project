using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        
        string sign = "";

        if (percent%10 >= 7 && percent < 97 && percent >= 60)
        {
            sign = "+";
        }
        else if (percent%10 < 3 && percent >= 60)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {grade}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats, you passed");
        }
        else
        {
            Console.WriteLine("Try harder next time");
        }
    }
}