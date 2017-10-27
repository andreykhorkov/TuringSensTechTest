using Buttons;
using UnityEngine;

public class TuringSensView : TuringSensElement
{
    [SerializeField] private BtnView clockBtnView;
    [SerializeField] private BtnView mainBtnView;
    [SerializeField] private CameraView mainCameraView;

    public BtnView ClockBtnView { get { return clockBtnView; } }
    public BtnView MainBtnView { get { return mainBtnView; } }
    public CameraView MainCameraView { get { return mainCameraView; } }
}
