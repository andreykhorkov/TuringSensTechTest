using UnityEngine;

public class CameraView : TuringSensElement
{
    public Animator Anim { get; private set; }

    protected override void Initialize()
    {
        Anim = GetComponent<Animator>();
    }
}