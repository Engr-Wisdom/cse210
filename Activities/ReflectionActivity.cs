using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram.Activities
{
    public class ReflectionActivity : Activity
    {
        private List<string> _prompts = new()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind?"
        };

        public ReflectionActivity()
            : base("Reflection Activity",
                   "This activity will help you reflect on times in your life when you have shown strength and resilience.") {}

        protected override void PerformActivity()
        {
            Random rand = new();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine($"\n{prompt}");
            Utils.AnimationHelper.ShowSpinner(3);

            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                string question = _questions[rand.Next(_questions.Count)];
                Console.Write($"\n> {question}");
                Utils.AnimationHelper.ShowSpinner(5);
            }
        }
    }
}
