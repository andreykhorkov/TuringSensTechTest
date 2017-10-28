using UnityEngine;

public class TuringSensModel : TuringSensElement
{
    [SerializeField] private PagesModel pagesModel;
    [SerializeField] private ClockModel clockModel;
    [SerializeField] private CubesModel cubesModel;

    public PagesModel PagesModel { get { return pagesModel; } }
    public ClockModel ClockModel { get { return clockModel; } }
    public CubesModel CubesModel { get { return cubesModel; } }
}
