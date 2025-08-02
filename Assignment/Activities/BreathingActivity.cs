using System;
using System.Threading;

namespace MindfulnessProgram.Activities
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() 
            : base("Breathing Activity", 
                   "This activity will help you relax by guiding you through slow breathing.") {}

        protected override void PerformActivity()
        {
            int interval = 4; // seconds per breath in/out
            int cycles = _duration / (interval * 2);

            for (int i = 0; i < cycles; i++)
            {
                Console.Write("\nBreathe in... ");
                Utils.AnimationHelper.ShowCountdown(interval);

                Console.Write("Breathe out... ");
                Utils.AnimationHelper.ShowCountdown(interval);
            }
        }
    }
}
