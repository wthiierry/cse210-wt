using System;
using System.Collections.Generic;

class Entry
{
    public DateTime _currentTime = DateTime.Now;
    public List<string> _menu = new List<string>();
    public List<string> _entries = new List<string>();
    public Entry()
    {

    }

    public string DateToString()
    {
        string _dateText = _currentTime.ToShortDateString();
        return _dateText;
    }

    public void DisplayEntries()
    {
        foreach (string _entry in _entries)
        {
            Console.WriteLine(_entry);
        }

    }

    public void LoadMenu()
    {
        _menu.Add("Please select one of the following choices:");
        _menu.Add("1. Write");
        _menu.Add("2. Display");
        _menu.Add("3. Load");
        _menu.Add("4. Save");
        _menu.Add("5. Quit");
    }

    public void menu()
    {
        foreach (string _menuItem in _menu)
        {
            Console.WriteLine($"{_menuItem}");
        }

    }

}