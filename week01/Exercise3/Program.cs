using System;
using System.Reflection.PortableExecutable;

namespace List
{
    class Program
    {
        static void Main(string[] arg)
        {
            List<int> numbers = new List<int>(); 

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            
            int number = -1;

            while (number != 0)
            {
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());

                numbers.Add(number);
            }

            int sum = 0;
            int average = 0;
            int maxNumber = numbers.Max();
            int minPositiveNumber = numbers.Where(n => n > 0).Min();

            foreach (int num in numbers)
            {
                sum += num;
                
            }

            if (numbers.Count > 0)
            {
                average += sum / numbers.Count;
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");
            Console.WriteLine($"The smallest positive number is: {minPositiveNumber}");
            Console.WriteLine("The sorted list is:");
            numbers.Sort();
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}