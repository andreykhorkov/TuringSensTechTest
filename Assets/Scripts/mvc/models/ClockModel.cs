using System;

public class ClockModel : TuringSensElement
{
    public DateTime CurrentTime { get; private set; }

    public void IncrementTime()
    {
        CurrentTime = CurrentTime.AddSeconds(1);
    }

    public void GetCorrectTime()
    {
        CurrentTime = DateTime.UtcNow;
    }
}