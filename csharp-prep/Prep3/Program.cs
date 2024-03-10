using System;

class Program
{
    static void Main(string[] args)
    {
        string answer;

        do
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);

            int guess = -1;

            while (guess != magicNum)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNum > guess)
                {
                    Console.WriteLine("Guess Higher");
                }
                else if (magicNum < guess)
                {
                    Console.WriteLine("Guess Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.Write("Do you want to play again?yes/no ");
            answer = Console.ReadLine();
        } while (answer == "Yes");
    }
}