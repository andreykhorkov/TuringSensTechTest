using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ClockView : TuringSensElement
{
    [SerializeField] private Text lblTime;

    protected override void Initialize()
    {
        base.Initialize();

        App.Controller.ClockController.OnTimerTick += DrawTime;
    }

    private void DrawTime(object sender, ClockTickArgs args)
    {
        lblTime.text = args.CurrentTime.ToString("hh:mm:ss", CultureInfo.InvariantCulture);
    }
}
