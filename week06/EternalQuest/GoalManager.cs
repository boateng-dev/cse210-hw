public class GoalManager
{
    private List<Goal> goals = new List<Goal>();

    public void CreateGoal()
    {
        GoalCreator creator = new GoalCreator();
        Goal goal = creator.Create();
        if (goal != null)
        {
            goals.Add(goal);
            Console.WriteLine("Goal created!");
        }
    }

    public void RecordGoal()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet!");
            return;
        }

        RecordGoal recorder = new RecordGoal(goals);
        recorder.Record();
    }

    public void ShowGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet!");
            return;
        }

        GoalDisplayer displayer = new GoalDisplayer(goals);
        displayer.Display();
    }

    public void DeleteGoal()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet!");
            return;
        }

        GoalDeleter deleter = new GoalDeleter(goals);
        deleter.Delete();
    }

    public void ShowScore()
    {
        int totalScore = 0;
        foreach (var goal in goals)
        {
            totalScore += goal.Score;
        }
        Console.WriteLine($"Your current score: {totalScore}");
    }
}
