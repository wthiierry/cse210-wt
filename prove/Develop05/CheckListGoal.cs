using System;

class CheckListGoal : Goals
{

    private int bonusScore;
    private int bonus;
    private int bonusAccomplish;
    private int score;
    private bool isComplete;
    private int itemToComplete;
    private string goalType;

    public override bool IsItComplete()
    {
        throw new NotImplementedException();
    }

    public override int RecoderEvent()
    {
        throw new NotImplementedException();
    }

    public int AddBonus()
    {
        return 1;
    }

    public override string ToCSVRecord()
    {
        throw new NotImplementedException();
    }
    public void setBonus()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        bonus = int.Parse(Console.ReadLine());
    }

    public void setBonusScore()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        bonusScore = int.Parse(Console.ReadLine());
    }
}