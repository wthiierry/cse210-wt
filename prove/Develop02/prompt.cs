using System;
using System.Collections.Generic;

class Prompt
{
    public List<string> _promptsList = new List<string>();
    public Prompt()
    {

    }

    public string DisplayRandomPrompt()
    {
        _promptsList.Add("Who was the most interesting person I interacted with today?");
        _promptsList.Add("What was the best part of my day?");
        _promptsList.Add("How did I see the hand of the Lord in my life today?");
        _promptsList.Add("What was the strongest emotion I felt today?");
        _promptsList.Add("If I had one thing I could do over today, what would it be?");
        Random rnd = new Random();
        int _randIndex = rnd.Next(_promptsList.Count);
        string _random = _promptsList[_randIndex];

        return _random;

    }
}