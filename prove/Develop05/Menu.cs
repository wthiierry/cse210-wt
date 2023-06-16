using System;

class Menu
{
    private string menuItems = string.Empty;

    public Menu()
    {

    }

    public static void DisplayMenu()
    {
        Goals.printTotalScore();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        processAnswerMainMenu();
    }

    public static void MenuNewGoal()
    {
        Console.WriteLine("The Type of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?: ");
        processAnswerGoalsMenu();
    }

    public void DisplayGoals()
    {

    }

    public static void processAnswerMainMenu()
    {
        int answer = int.Parse(Console.ReadLine());
        switch (answer)
        {
            case 1:
                MenuNewGoal();
                break;
            case 2:
                Goals.GoalToList();
                DisplayMenu();
                break;
            case 3:
                Goals.CreateFile();
                break;
            case 4:
                DisplayMenu();
                break;
            case 5:
                DisplayMenu();
                break;
            case 6:
                Environment.Exit(0);
                break;
        }

    }

    public static void processAnswerGoalsMenu()
    {
        int answer = int.Parse(Console.ReadLine());
        SimpleGoal simple = new SimpleGoal();
        simple.setType("Simple");
        EternalGoal eternal = new EternalGoal();
        eternal.setType("Eternal");
        CheckListGoal checkList = new CheckListGoal();
        checkList.setType("CheckList");
        switch (answer)
        {
            case 1:
                simple.setGoalName();
                simple.setGoalDescription();
                simple.setScore();
                simple.GoalToString();
                DisplayMenu();
                break;
            case 2:
                eternal.setGoalName();
                eternal.setGoalDescription();
                eternal.setScore();
                eternal.GoalToString();
                DisplayMenu();
                break;
            case 3:
                checkList.setGoalName();
                checkList.setGoalDescription();
                checkList.setScore();
                checkList.setBonus();
                checkList.setBonusScore();
                checkList.GoalToString();
                DisplayMenu();
                break;
        }
    }
}