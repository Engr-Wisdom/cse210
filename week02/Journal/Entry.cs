using System;
using GeneratePrompt;

namespace JournalEntry
{
    public class Entry
    {
        public string _prompt;
        public string _response;
        public string _date = DateTime.Now.ToShortDateString();

        public string DisplayEntry()
        {
            return $"Date: {_date} | Prompt: {_prompt} | Response: {_response}";
        }
    }
}