using Buttons;
using UnityEngine;

public class TuringSensView : TuringSensElement
{
    [SerializeField] private BtnView clockView;
    [SerializeField] private BtnView mainView;
    [SerializeField] private CameraView mainCameraView;

    public BtnView ClockView { get { return clockView; } }
    public BtnView MainView { get { return mainView; } }
    public CameraView MainCameraView { get { return mainCameraView; } }
}
