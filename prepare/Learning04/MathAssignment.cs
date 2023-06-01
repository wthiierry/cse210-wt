using System;

class MathAssignment : Assignment
{

    private string textBookSection = string.Empty;
    private string problems = string.Empty;

    public MathAssignment(string studentName, string topic, string _textBookSection, string _problems) : base(studentName, topic)
    {
        textBookSection = _textBookSection;
        problems = _problems;
    }

    public string GetHomeworkList()
    {
        return string.Concat("Section", textBookSection, " Problems", problems);
    }
}