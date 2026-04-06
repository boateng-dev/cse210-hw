using System;
using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.Write("How long would you like to do this activity? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        Spinner(5);
        Run();
        Finish();
    }

    public abstract void Run();

    private void Finish()
    {
        Console.WriteLine("Great job!");
        Spinner(3);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        Spinner(3);
    }

    protected void Spinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < futureTime)
        {
            switch (i % 4)
            {
                case 0:
                    Console.Write("\r|");
                    break;
                case 1:
                    Console.Write("\r/");
                    break;
                case 2:
                    Console.Write("\r-");
                    break;
                case 3:
                    Console.Write("\r\\");
                    break;
            }
            Thread.Sleep(250);
            i++;
        }
        Console.Write("\r \r");
    }
}
