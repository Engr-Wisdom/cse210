using System;

namespace cse210
{
    public class Exercise2
    {
        public static void Run()
        {
            Console.Write("Enter Your Grade: ");
            float grade = float.Parse(Console.ReadLine()!);

            string gradeLetter = "";
            string gradeSign = "";
            int lastDigit = (int)grade % 10;

            if (grade >= 90)
            {
                gradeLetter = "A";
            }
            else if (grade >= 80)
            {
                gradeLetter = "B";
            }
            else if (grade >= 70)
            {
                gradeLetter = "C";
            }
            else if (grade >= 60)
            {
                gradeLetter = "D";
            }
            else
            {
                gradeLetter = "F";
            }

            // Add "+" or "-" sign only if gradeLetter is not "F"
            if (gradeLetter != "F")
            {
                if (lastDigit >= 7)
                {
                    gradeSign = "+";
                }
                else if (lastDigit < 3)
                {
                    gradeSign = "-";
                }
            }

            // No A+ allowed
            if (grade >= 97)
            {
                gradeLetter = "A";
                gradeSign = "";
            }

            Console.WriteLine($"Your grade is: {gradeLetter}{gradeSign}");

            if (grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course");
            }
            else
            {
                Console.WriteLine("Don't worry, keep trying—you will do better next time.");
            }
        }
    }
}
