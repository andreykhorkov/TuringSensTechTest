using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Animator animator;
    private int setView2Id = Animator.StringToHash("SetView2");

    public enum Views
    {
        view1,
        view2
    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger(setView2Id);
        }

        if (Input.GetKey(KeyCode.B))
        {
            animator.SetTrigger("SetView1");
        }
    }
}
