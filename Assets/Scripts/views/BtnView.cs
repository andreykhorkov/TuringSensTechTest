using UnityEngine;
using UnityEngine.EventSystems;

namespace Buttons
{
    public class BtnView : TuringSensElement, IPointerClickHandler
    {
        protected Animator animator;
        protected int viewIdToSet;
        [SerializeField] protected string viewName;

        void Start()
        {
            Initialize();
        }

        protected override void Initialize()
        {
            animator = GetComponent<Animator>();
            viewIdToSet = Animator.StringToHash(viewName);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            animator.SetTrigger(viewIdToSet);
        }
    }
}
