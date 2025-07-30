using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = scriptureText.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        if (visibleWords.Count == 0) return;

        Random rnd = new Random();
        for (int i = 0; i < count; i++)
        {
            var candidates = _words.Where(w => !w.IsHidden()).ToList();
            if (candidates.Count == 0) break;

            int index = rnd.Next(candidates.Count);
            candidates[index].Hide();
        }
    }

    public string DisplayCurrentScripture()
    {
        string text = string.Join(" ", _words.Select(w => w.Display()));
        return $"{_reference}\n\n{text}";
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
