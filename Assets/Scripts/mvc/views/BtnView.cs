using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public enum Pages
{
    main,
    clock
}

public class BtnView : TuringSensElement, IPointerClickHandler
{
    [SerializeField] protected string viewName;

    protected int viewIdToSet;
    protected Button button;

    protected override void Initialize()
    {
        base.Initialize();
        viewIdToSet = Animator.StringToHash(viewName);
        button = GetComponent<Button>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        App.Controller.PagesController.SetPage(viewIdToSet);
    }
}
