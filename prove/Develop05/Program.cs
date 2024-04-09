using System;

class Program : GoalManager
{
    static GoalManager goalManager = new GoalManager();
    
    static void Main(string[] args)
    {
        //GoalManager goalManager = new GoalManager();

        //goalManager.DisplayPlayerInfo();
        //Console.WriteLine();

        bool exit = false;
        while (!exit)
        {
            goalManager.DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            //string choice = Console.ReadLine();
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    goalManager.ListGoalDetails();
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string saveFilename = Console.ReadLine();
                    goalManager.SaveGoals(saveFilename);
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    string loadFilename = Console.ReadLine();
                    goalManager.LoadGoals(loadFilename);
                    break;
                case 5:
                    Console.Write("Which goal did you accomplish? ");
                    int goalIndex = int.Parse(Console.ReadLine());
                    goalManager.RecordEvent(goalIndex);
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create: ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                CreateSimpleGoal();
                break;
            case "2":
                CreateEternalGoal();
                break;
            case "3":
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }

    static void CreateSimpleGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        SimpleGoal goal = new SimpleGoal(name, description, points);
        goalManager.AddGoal(goal);
        //Console.WriteLine("Simple Goal created successfully.");
    }

    static void CreateEternalGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        EternalGoal goal = new EternalGoal(name, description, points);
        goalManager.AddGoal(goal);
        //Console.WriteLine("Eternal Goal created successfully.");
    }

    static void CreateChecklistGoal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
        goalManager.AddGoal(goal);
        //Console.WriteLine("Checklist Goal created successfully.");
    }
}