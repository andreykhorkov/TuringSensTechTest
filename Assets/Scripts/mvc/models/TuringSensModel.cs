using UnityEngine;

public class TuringSensModel : TuringSensElement
{
    [SerializeField] private PagesModel pagesModel;
    [SerializeField] private ClockModel clockModel;

    public PagesModel PagesModel { get { return pagesModel; } }
    public ClockModel ClockModel { get { return clockModel; } }
}
