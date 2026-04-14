public class GoalDisplayer
{
    private List<Goal> goals;

    public GoalDisplayer(List<Goal> goals)
    {
        this.goals = goals;
    }

    public void Display()
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
    }
}
