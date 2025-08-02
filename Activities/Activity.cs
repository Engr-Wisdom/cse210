using System;

namespace MindfulnessProgram.Activities
{
    public abstract class Activity
    {
        private string _name;
        private string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}!\n{_description}");
            Console.Write("Enter the duration in seconds: ");
            _duration = int.Parse(Console.ReadLine());

            Console.WriteLine("\nGet ready to begin...");
            Utils.AnimationHelper.ShowSpinner(3);

            PerformActivity();

            Console.WriteLine("\nWell done!");
            Utils.AnimationHelper.ShowSpinner(2);
            Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
            Utils.AnimationHelper.ShowSpinner(2);
        }

        protected abstract void PerformActivity();
    }
}
