public class SimpleGoal : Goal
{
    public bool IsComplete { get; set; }

    public override void Record()
    {
        if (!IsComplete)
        {
            Score += Points;
            IsComplete = true;
            Console.WriteLine($"Recorded Simple Goal: {Name} (+{Points} points)");
        }
        else
        {
            Console.WriteLine("Goal already completed!");
        }
    }
}
