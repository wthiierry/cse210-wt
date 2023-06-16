using System;

public abstract class Goals
{
    private static int score = 0;
    private static int totalScore = 0;
    string name = string.Empty;
    string description = string.Empty;
    string completeSymbol = string.Empty;
    int bonus;
    int bonusScore;
    bool isComplete;
    string goalString = string.Empty;
    static List<string> goalList = new List<string>();
    List<int> scoreList = new List<int>();
    string type = string.Empty;

    public void setScore()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        score = int.Parse(Console.ReadLine());
    }

    public void setType(string _type)
    {
        type = _type;
    }

    public string getType()
    {
        return type;
    }
    public int getScore()
    {
        return score;
    }

    public void setTotalScore()
    {
        totalScore = totalScore + score;
    }

    public int getTotalScore()
    {
        return totalScore;
    }

    public void setGoalName()
    {
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
    }
    public void setGoalDescription()
    {
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
    }

    public static void printTotalScore()
    {
        Console.WriteLine($"You have {totalScore} points.");
    }

    public abstract bool IsItComplete();
    public abstract int RecoderEvent();
    public abstract void ToCSVRecord();
    public void GoalToString()
    {
        if (type == "Simple" || type == "Eternal")
        {
            goalString = "[] " + name + " (" + description + ")";
        }
        else
        {
            goalString = "[] " + name + " (" + description + ") -- Currently completed: 0/" + bonus;
        }

        setGoalToList();
    }

    public void setGoalToList()
    {
        goalList.Add(goalString);
    }
    public static void GoalToList()
    {
        int index = 1;
        Console.WriteLine("The goals are: ");
        foreach (string item in goalList)
        {
            Console.WriteLine($"{index.ToString()} {item}");
            index++;
        };
    }
    public List<int> ScoreToList()
    {
        return scoreList;
    }
    public List<string> TypeToList()
    {
        return goalList;
    }
    public void SaveGoals()
    {

    }

    public static string CreateFile()
    {
        Console.Write("What is the filename fo the goal file? ");
        string filename = Console.ReadLine();
        using (FileStream fs = File.Create(filename)) { }
        return filename;
    }

}