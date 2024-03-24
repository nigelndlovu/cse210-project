using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");
        DisplayScripture(scripture);
        //scripture.GetDisplayText();

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to continue hiding words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
            Console.Clear();
            //scripture.GetDisplayText();
            DisplayScripture(scripture);
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine($"{scripture.GetReferenceText()}");
        Console.WriteLine($"{scripture.GetDisplayText()}");
    }
}