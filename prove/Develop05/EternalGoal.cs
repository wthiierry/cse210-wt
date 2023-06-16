using System;

class EternalGoal : Goals
{
    private int score;
    private bool isComplete;
    private string goalType;

    public override bool IsItComplete()
    {
        return true;
    }

    public override int RecoderEvent()
    {
        return 1;
    }

    public override string ToCSVRecord()
    {
        return "trest";
    }
}