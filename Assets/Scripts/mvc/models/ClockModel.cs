using System;

public class ClockTickArgs : EventArgs
{
    public DateTime CurrentTime { get; private set; }

    public ClockTickArgs(DateTime currentTime)
    {
        CurrentTime = currentTime;
    }
}

public class ClockModel : TuringSensElement
{
    private PeriodicTask clockTick;
    private PeriodicTask timeCorrection;

    public DateTime currentTime;
    public event EventHandler<ClockTickArgs> OnTimerTick = delegate { }; 

    protected override void Initialize()
    {
        base.Initialize();

        GetCurrentTime();
        clockTick = new PeriodicTask(Tick, 1);
        timeCorrection = new PeriodicTask(GetCurrentTime, 3600);
    }

    private void Tick()
    {
        currentTime = currentTime.AddSeconds(1);
        OnTimerTick(this, new ClockTickArgs(currentTime));
    }

    private void GetCurrentTime()
    {
        currentTime = DateTime.UtcNow;
    }

    // yes, i know about coroutines, but with this way it is easier to maintain/debug at those cases when you dealing with 
    // lots of coroutines working at the same time especially with objects that could be destroyed. I use coroutines for WWW requests kind of
    // tasks, but here i prefer deal with these Periodic Tasks which gives the same results as coroutines, but makes it cleaner (IMHO)
    void Update()
    {
        clockTick.TryExecute();
        timeCorrection.TryExecute();
    }
}