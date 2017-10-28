using UnityEngine;

public class ClockPageView : PageView
{
    [SerializeField] private ClockView clockView;

    public ClockView ClockView { get { return clockView; } }
}
