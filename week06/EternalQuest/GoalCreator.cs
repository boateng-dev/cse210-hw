public class GoalCreator
{
    public Goal Create()
    {
        Console.Write("\nEnter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("\nGoal type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Choose goal type: ");
        if (int.TryParse(Console.ReadLine(), out int type))
        {
            return type switch
            {
                1 => CreateSimpleGoal(name),
                2 => CreateEternalGoal(name),
                3 => CreateChecklistGoal(name),
                _ => null
            };
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return null;
        }
    }

    private Goal CreateSimpleGoal(string name)
    {
        string description = "A one-time goal that gives you points when completed.";
        Console.WriteLine($"Simple Goal: {description}");
        Console.Write("Enter points for completing this goal: ");
        if (int.TryParse(Console.ReadLine(), out int points))
        {
            return new SimpleGoal { Name = name, Points = points };
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return null;
        }
    }

    private Goal CreateEternalGoal(string name)
    {
        string description = "A goal you can do multiple times, earning points each time.";
        Console.WriteLine($"Eternal goal: {description}");
        Console.Write("Enter points for each time you do this: ");
        if (int.TryParse(Console.ReadLine(), out int points))
        {
            return new EternalGoal { Name = name, Points = points };
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return null;
        }
    }

    private Goal CreateChecklistGoal(string name)
    {
        string description = "A goal you need to do a certain number of times.";
        Console.WriteLine($"Checklist Goal: {description}");
        Console.Write("Enter points for completing this goal: ");
        if (int.TryParse(Console.ReadLine(), out int points))
        {
            Console.Write("Enter target count: ");
            if (int.TryParse(Console.ReadLine(), out int targetCount))
            {
                return new ChecklistGoal { Name = name, Points = points, TargetCount = targetCount };
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return null;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return null;
        }
    }
}
