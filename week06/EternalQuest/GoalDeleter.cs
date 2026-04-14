public class GoalDeleter
{
    private List<Goal> goals;

    public GoalDeleter(List<Goal> goals)
    {
        this.goals = goals;
    }

    public void Delete()
    {
        Console.WriteLine("\nYour goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            string status = goals[i] switch
            {
                SimpleGoal sg => sg.IsComplete ? "Completed" : "Not Completed",
                ChecklistGoal cg => $"{cg.CurrentCount}/{cg.TargetCount} completed",
                _ => ""
            };
            Console.WriteLine($"{i + 1}. {goals[i].Name} ({goals[i].GetType().Name}) - {status}");
        }

        Console.Write("\nChoose goal to delete (1-{0}): ", goals.Count);
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            index -= 1;
            if (index >= 0 && index < goals.Count)
            {
                goals.RemoveAt(index);
                Console.WriteLine("✅ Goal deleted!");
            }
            else
            {
                Console.WriteLine("😕 Invalid choice!");
            }
        }
        else
        {
            Console.WriteLine("😕 Invalid input. Please enter a number.");
        }
    }
}
