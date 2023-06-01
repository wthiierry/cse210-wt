using System;

class WrittingAssignment : Assignment
{

    private string title = string.Empty;
    public WrittingAssignment(string studentName, string topic, string _title) : base(studentName, topic)
    {

        title = _title;

    }

    public string GetWritingInformation()
    {
        return title;
    }
}