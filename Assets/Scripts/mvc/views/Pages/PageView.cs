using UnityEngine;

public abstract class PageView : TuringSensElement
{
    [SerializeField] protected BtnView btnView;

    public BtnView BtnView { get { return btnView; } }
}