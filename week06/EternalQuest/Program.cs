class Program
{
    static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest! ");

        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Goal");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Delete Goal");
            Console.WriteLine("5. Show Score");
            Console.WriteLine("6. Exit");

            Console.Write("\nChoose an option: ");
            if (int.TryParse(Console.ReadLine(), out int option))
            {
                switch (option)
                {
                    case 1:
                        goalManager.CreateGoal();
                        break;
                    case 2:
                        goalManager.RecordGoal();
                        break;
                    case 3:
                        goalManager.ShowGoals();
                        break;
                    case 4:
                        goalManager.DeleteGoal();
                        break;
                    case 5:
                        goalManager.ShowScore();
                        break;
                    case 6:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
