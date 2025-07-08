using System;

namespace cse210
{
    class Exercise4
    {
        static void Main(String[] args)
        {
            List<int> numbers = new List<int>();
            int user = -1;

            while (user != 0)
            {
                Console.Write("Enter number: ");
                user = int.Parse(Console.ReadLine()!);

                if (user != 0)
                {
                    numbers.Add(user);
                }
            }

            int sum = 0;
            int max = numbers.Max();

            foreach (int number in numbers)
            {
                sum += number;
            }

            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The Largest number is: {max}");

            var positiveNumbers = numbers.Where(n => n > 0);

            if (positiveNumbers.Any())
            {
                int smallestNumber = positiveNumbers.Min();
                Console.WriteLine($"The smallest positive number is: {smallestNumber}");
            }

            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}