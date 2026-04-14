public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public int Score { get; set; }

    public abstract void Record();
}
