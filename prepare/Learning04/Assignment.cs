using System;

class Assignment
{

    private string studentName = string.Empty;
    private string topic = string.Empty;

    public Assignment(string _studentName, string _topic)
    {
        studentName = _studentName;
        topic = _topic;
    }

    public string getSummary()
    {
        return string.Concat(studentName, " - ", topic);
    }
}