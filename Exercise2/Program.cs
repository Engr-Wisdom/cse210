using System;

namespace cse210
{
    class Exercise2
    {
        static void Main(string[] args)
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
                gradeLetter = "C"; // Capitalized "C"
            }
            else if (grade >= 60)
            {
                gradeLetter = "D";
            }
            else
            {
                gradeLetter = "F";
            }

            if (gradeLetter != "F")
            {
                if (lastDigit >= 7)
                {
                    gradeSign += "+";
                }
                else if (lastDigit < 3)
                {
                    gradeSign += "-";
                }
                else
                {
                    gradeSign += "";
                }
            }

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
                Console.WriteLine("Don't worry keep trying you will do better next time");
            }
        }
    }
}
