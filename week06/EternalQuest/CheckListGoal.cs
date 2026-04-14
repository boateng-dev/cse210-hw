public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }

    public override void Record()
    {
        CurrentCount++;
        if (CurrentCount <= TargetCount)
        {
            Score += Points;
            Console.WriteLine($"Recorded Checklist Goal: {Name} (+{Points} points)");
            if (CurrentCount == TargetCount)
            {
                Console.WriteLine("Goal completed!");
            }
        }
        else
        {
            Console.WriteLine("Goal already completed!");
        }
    }
}
