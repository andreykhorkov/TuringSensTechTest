using UnityEngine;

public class TuringSensController : TuringSensElement
{
    [SerializeField] ClockController clockController;
    [SerializeField] CubesController cubesController;
    [SerializeField] PagesController pagesController;

    public ClockController ClockController { get { return clockController; } }
    public CubesController CubesController { get { return cubesController; } }
    public PagesController PagesController { get { return pagesController; } }
}
