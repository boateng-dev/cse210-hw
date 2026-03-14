using System;

class Program
{
    static void Main(string[] args)
    {
        {
            List<double> numbers = new List<double>();

            Console.WriteLine("Enter a numbers, type 0 when ending.");
            while (true)
            {
                Console.Write("Enter number: ");
                double number = Convert.ToDouble(Console.ReadLine());
                if (number == 0)
                    break;
                numbers.Add(number);
            }

            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            double average = sum / numbers.Count;
            double max = double.MinValue;
            foreach (var number in numbers)
            {
                if (number > max)
                    max = number;
            }

            Console.WriteLine($"The max is: {max}");
        }
    }
}