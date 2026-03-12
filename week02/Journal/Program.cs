using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int grade = Convert.ToInt32(Console.ReadLine());
        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is: {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course");
        }
        else
        {
            Console.WriteLine("Don't worry, you try again next time");
        }
    }
}