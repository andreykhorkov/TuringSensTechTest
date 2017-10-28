using UnityEngine;

public class TuringSensView : TuringSensElement
{
    [SerializeField] private PageView mainPageView;
    [SerializeField] private PageView clockPageView;
    [SerializeField] private CameraView mainCameraView;

    public PageView MainPageView { get { return mainPageView; } }
    public PageView ClockPageView { get { return clockPageView; } }
    public CameraView MainCameraView { get { return mainCameraView; } }
}
