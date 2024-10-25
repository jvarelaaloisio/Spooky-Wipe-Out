using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAnimationController : MonoBehaviour
{
    private static readonly int IsBeingCaptured = Animator.StringToHash("isBeingCaptured");
    [SerializeField] private Animator animator;

    public void SetVacuumedState(bool state)
    {
        animator.SetBool(IsBeingCaptured, state);
    }
}
