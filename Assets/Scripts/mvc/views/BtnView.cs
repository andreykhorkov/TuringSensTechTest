using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public enum Pages
{
    main,
    clock
}

public class BtnView : TuringSensElement
{
    [SerializeField] protected PageView pageView;

    protected int viewIdToSet;
    protected Button button;

    protected override void Initialize()
    {
        base.Initialize();
        viewIdToSet = Animator.StringToHash(pageView.name);
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        App.Controller.PagesController.SetPage(viewIdToSet);
    }
}
