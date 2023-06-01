using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Math Assignments ");
        Console.WriteLine("TextBookSection: ");
        string textBookSection = Console.ReadLine();
        Console.WriteLine("Problems: ");
        string problems = Console.ReadLine();
        Console.WriteLine("Writting Assignments");
        Console.WriteLine("Title: ");
        string title = Console.ReadLine();
        MathAssignment mathAsg = new MathAssignment(name, "Math Assignments", textBookSection, problems);
        WrittingAssignment wrtAsg = new WrittingAssignment(name, "Math Assignments", title);

        Console.WriteLine(mathAsg.getSummary());
        Console.WriteLine(mathAsg.GetHomeworkList());
        Console.WriteLine(wrtAsg.GetWritingInformation());
    }
}