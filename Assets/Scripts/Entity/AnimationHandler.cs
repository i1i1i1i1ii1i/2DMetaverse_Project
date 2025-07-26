using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private static readonly int isMoving = Animator.StringToHash("IsMove");
    private static readonly int hori = Animator.StringToHash("Horizontal");
    private static readonly int ver = Animator.StringToHash("Vertical");

    protected Animator animator;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void Move(Vector2 obj)
    {
        animator.SetBool(isMoving, obj.magnitude > 0.5f);
        animator.SetFloat(hori, obj.x);
        animator.SetFloat(ver, obj.y);
    }
}
