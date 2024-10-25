using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    [SerializeField] private Animator animator;
    
    public void SetWalkState(bool isWalking)
    {
        animator.SetBool(IsWalking, isWalking);
    }
}