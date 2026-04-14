public class EternalGoal : Goal
{
    public override void Record()
    {
        Score += Points;
        Console.WriteLine($"Recorded Eternal Goal: {Name} (+{Points} points)");
    }
}
