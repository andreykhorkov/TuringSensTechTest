using UnityEngine;
using UnityEngine.EventSystems;

public enum Pages
{
    main,
    clock
}

public class BtnView : TuringSensElement, IPointerClickHandler
{
    protected int viewIdToSet;
    [SerializeField]
    protected string viewName;

    protected override void Initialize()
    {
        base.Initialize();
        viewIdToSet = Animator.StringToHash(viewName);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (App.Model.CurrentPageId == viewIdToSet)  // this check is probably unnecessary since you can`t click btn on the other page
        {
            return;
        }

        App.View.MainCameraView.Anim.SetTrigger(viewIdToSet);
        App.Model.SetCurrentView(viewIdToSet);
    }
}
