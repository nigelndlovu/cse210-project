using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int numberList = -1;
        while (numberList != 0)
        {
            Console.Write("Enter number: ");

            string userInput = Console.ReadLine();
            numberList = int.Parse(userInput);

            if (numberList != 0)
            {
                numbers.Add(numberList);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min && number > 0)
            {
                min = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {min}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        for (int i = 0; i < numbers.Count; i++)
        {
            int number = numbers[i];
            Console.WriteLine(number);
        }
    }
}