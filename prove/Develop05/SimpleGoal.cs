using System;

class SimpleGoal : Goals
{
    private int score;
    private bool isComplete;
    private string goalType;

    public SimpleGoal()
    {

    }
    public override bool IsItComplete()
    {
        return true;
    }

    public override int RecoderEvent()
    {
        return 1;
    }

    public override void ToCSVRecord()
    {
        return "text";
    }
}