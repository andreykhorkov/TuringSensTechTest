using UnityEngine;
using UnityEngine.EventSystems;

namespace Buttons
{
    public class BtnView : TuringSensElement, IPointerClickHandler
    {
        protected int viewIdToSet;
        [SerializeField] protected string viewName;

        void Start()
        {
            Initialize();
        }

        protected override void Initialize()
        {
            viewIdToSet = Animator.StringToHash(viewName);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            App.View.MainCameraView.Anim.SetTrigger(viewIdToSet);
        }
    }
}
