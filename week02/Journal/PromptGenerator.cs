using System;
public class PromptGenerator
{
    public string[] prompts = [
        "Who was the most person you interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the most strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? "
    ];

    Random random = new Random();

    public string RandomPrompt()
    {
        int index = random.Next(prompts.Length);
        string prompt = prompts[index];
        return prompt;
    }
}
