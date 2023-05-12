using System;

class Program
{

    static void Main(string[] args)
    {
        int _answer = 0;
        string _promptText = string.Empty;
        string _flname = string.Empty;
        Entry _entry = new Entry();
        Journal _journal = new Journal();
        _entry.LoadMenu();

        while (_answer != 5)
        {
            _entry.menu();
            _answer = int.Parse(Console.ReadLine());

            if (_answer == 1)
            {
                Prompt _prompt = new Prompt();
                _promptText = _prompt.DisplayRandomPrompt();
                Console.WriteLine(_promptText);
                string _answerEntry = Console.ReadLine();
                string dateText = _entry.DateToString();
                _entry._entries.Add($"Date: {dateText} - Prompt: {_promptText} \n  {_answerEntry}");
            }
            else if (_answer == 2)
            {
                if (File.Exists(_journal._filename))
                {
                    _journal.DisplayContentFile();
                }
                else
                {
                    foreach (string p in _entry._entries)
                    {
                        Console.WriteLine($"{p}");
                    }

                }
            }
            else if (_answer == 3)
            {
                Console.WriteLine("What is the filename? ");
                _flname = Console.ReadLine();
                _journal._filename = _flname;

            }
            else if (_answer == 4)
            {
                if (File.Exists(_journal._filename))
                {
                    foreach (string p in _entry._entries)
                    {
                        _journal.WriteFile(p);
                    }
                }
                else
                {
                    Console.WriteLine("What is the filename? ");
                    _flname = Console.ReadLine();
                    _journal._filename = _flname;
                    _journal.CreateFile();
                    foreach (string p in _entry._entries)
                    {
                        _journal.WriteFile(p);
                    }
                }
            }
        }


    }


}