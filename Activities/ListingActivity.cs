using System;
using System.Collections.Generic;

namespace MindfulnessProgram.Activities
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
            : base("Listing Activity",
                   "This activity will help you reflect on the good things in your life by listing as many as you can.") {}

        protected override void PerformActivity()
        {
            Random rand = new();
            string prompt = _prompts[rand.Next(_prompts.Count)];

            Console.WriteLine($"\n{prompt}");
            Utils.AnimationHelper.ShowCountdown(5);

            List<string> items = new();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                items.Add(input);
            }

            Console.WriteLine($"\nYou listed {items.Count} items. Great job!");
        }
    }
}
